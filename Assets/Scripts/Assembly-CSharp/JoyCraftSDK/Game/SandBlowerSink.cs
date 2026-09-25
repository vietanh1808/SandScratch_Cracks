using System;
using System.Collections.Generic;
using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	public class SandBlowerSink : JMonoBehaviour
	{
		[Serializable]
		private enum BoosterState
		{
			Idle = 0,
			Appearing = 1,
			Sucking = 2,
			MovingToSpray = 3,
			Spraying = 4,
			Hiding = 5
		}

		private const string Group_Refs = "Refs";

		private const string Group_Move = "Chuyển động booster (A/D/N/cột)";

		private const string Group_Line = "Ống hút B + kho C";

		private const string Group_Debug = "Debug";

		private const float BeltCoverRadius = 10000f;

		[Tooltip("Máy thổi cát trong scene — sink tự Play/Stop hiệu ứng MMF + outline. Anim clip nằm ở blowerAnim.")]
		[FormerlySerializedAs("magnet")]
		[SerializeField]
		private ASandBlower blower;

		[Tooltip("Anim máy thổi (Animancer): appear/blow/disappear, mỗi cái báo XONG bằng callback -> sink chờ đúng lúc clip kết thúc mới đi bước kế. Trống -> tự FindAnyObjectByType lúc Build/bấm (anim nằm TRONG \"SandBlower.prefab\", sink ở prefab khác nên KHÔNG wire chéo được lúc edit); vẫn không thấy -> bỏ qua anim, flow vẫn chạy (fail-open) + LogWarning.")]
		[SerializeField]
		private ASandBlowerAnim blowerAnim;

		[Tooltip("Jar controller — nguồn jar đích lúc phun + FillColorAnyDepth cho phần dư không có hạt visual. Trống -> tự FindAnyObjectByType lúc bấm booster; vẫn không thấy -> chặn lượt + hoàn booster.")]
		[SerializeField]
		private ColorJarController colorJarController;

		[Tooltip("Object DI CHUYỂN/XOAY cả lượt. Trống -> transform gốc của SandBlower. Cũng là ANCHOR của ống B + kho C (hạt bám theo như SetParent). ⚠ Clip anim KHÔNG được key position/rotation của CHÍNH object này (Animator đè tween mỗi frame -> máy đứng yên dù tween 'chạy xong') — để Animancer + model ở object CON.")]
		[SerializeField]
		private Transform boosterRoot;

		[Tooltip("Vị trí A — booster tween tới đây (kèm XOAY theo rotation của điểm này) rồi mới hút. BẮT BUỘC.")]
		[SerializeField]
		private Transform appearPoint;

		[Tooltip("Vị trí D — hút xong booster tween tới đây (kèm XOAY theo rotation của điểm này) rồi mới phun; phun xong cũng xoay về rotation này trước anim disappear. BẮT BUỘC.")]
		[SerializeField]
		private Transform sprayPoint;

		[Tooltip("Điểm ĐỨNG + HƯỚNG từng cột jar (index = cột 0..3) — phun vào jar cột nào thì move+rotate tới transform cột đó (như A/D: kéo/xoay empty trong Scene view). Thiếu/null -> đứng nguyên chỗ + LogWarning.")]
		[SerializeField]
		private List<Transform> columnPoints;

		[Tooltip("Thời gian tween DI CHUYỂN + XOAY (1 config chung cho cả position lẫn rotation) khi tới D và về lại D lúc hide. Tới A KHÔNG tween — đặt thẳng transform (spec 2026-07-28).")]
		[SerializeField]
		[Min(0.01f)]
		private float moveDuration;

		[SerializeField]
		private EasingType moveEase;

		[Tooltip("Thời gian tween DI CHUYỂN + XOAY khi NHẮM CỘT jar lúc phun (blow) — config RIÊNG với moveDuration.")]
		[SerializeField]
		[Min(0.01f)]
		private float rotateDuration;

		[SerializeField]
		private EasingType rotateEase;

		[Tooltip("Delay (giây) từ lúc máy TỚI vị trí A (anim xuất hiện bắt đầu chạy SONG SONG) đến lúc bắt đầu hút cát — thay cơ chế cũ chờ HẾT anim appear mới hút.")]
		[SerializeField]
		[Min(0f)]
		private float suckStartDelay;

		[Tooltip("Thời gian tối đa (giây) cho phase hút — timeout guard phòng hạt visual kẹt không vào kho. Phase hút kết thúc khi hạt hút xong bay hết vào kho, HOẶC khi vượt quá giá trị này.")]
		[SerializeField]
		[Min(0.1f)]
		private float maxSuckTime;

		[Tooltip("B1 — đầu ống hút (phía belt lúc hút / phía jar lúc phun). Nên là CON của boosterRoot để ống xoay theo. BẮT BUỘC.")]
		[SerializeField]
		private Transform lineStart;

		[Tooltip("B2 — cuối ống, CỬA kho C (B2 nằm trên mép đường tròn kho; tâm kho suy ra = B2 + hướng(B1->B2)·radius). Nên là CON của boosterRoot. BẮT BUỘC.")]
		[SerializeField]
		private Transform lineEnd;

		[Tooltip("Knob đàn hạt: tốc độ hút/phun, bề rộng ống, bán kính kho, nhịp nhả.")]
		[SerializeField]
		private CapturedGrainSwarm.Settings swarmSettings;

		[Tooltip("Log chi tiết rót/đổ bỏ pixel theo màu.")]
		[SerializeField]
		private bool debugLog;

		[Tooltip("Vẽ gizmo ống B (2 mép theo lineWidth) + vòng tròn kho C.")]
		[SerializeField]
		private bool drawGizmos;

		private readonly Dictionary<int, int> _bank;

		private readonly List<ObiFlowEmitters.HarvestedGrain> _captured;

		private readonly List<int> _dischargeOrder;

		private CapturedGrainSwarm _swarm;

		private CapturedGrainRenderer _swarmRenderer;

		private GrainFlowBackend _backend;

		private BoosterState _state;

		private ColorJar _targetJar;

		private int _dischargeIndex;

		private bool _rotating;

		private int _runGen;

		private float _suckElapsed;

		private Sequence _moveSeq;

		public void Begin(GrainFlowBackend backend)
		{
		}

		public void StopBlower()
		{
		}

		private void DisposeSwarm()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnExecuteMagnetBooster(ref AEventManager.OnExecuteMagnetBooster eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private void SetMachineActive(bool active)
		{
		}

		private ASandBlowerAnim ResolveAnim()
		{
			return null;
		}

		private Transform ResolveRoot()
		{
			return null;
		}

		private void StartSuck()
		{
		}

		private void SweepOnce()
		{
		}

		private void DrainCaptured()
		{
		}

		private void FinishSuck()
		{
		}

		private void StartSpraySequence()
		{
		}

		private void TickSpray()
		{
		}

		private void AdvanceColor()
		{
		}

		private bool TryAimColor(int colorId)
		{
			return false;
		}

		private void PlayAnim(Func<ASandBlowerAnim, Action<Action>> pick, int gen, Action onDone)
		{
		}

		private void CloseSprayJar(ColorJar jar)
		{
		}

		private Transform ColumnPoint(int column)
		{
			return null;
		}

		private void AimAt(Transform point, TweenCallback onDone)
		{
		}

		private void BeginHide()
		{
		}

		private void FinishRun()
		{
		}

		private void HandleGrainArrived(int colorId, int carried)
		{
		}

		private void FlushColorBank(int colorId)
		{
		}

		private void KillTweens(Transform root)
		{
		}

		private void Cancel()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
