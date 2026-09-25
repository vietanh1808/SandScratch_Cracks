using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class IceBlocker : AIceBlocker
	{
		[Tooltip("Sàn thời gian giữ trước khi trả pool khi hình VỠ (giây) — dùng khi KHÔNG có particle; có particle thì lấy đời particle nếu dài hơn.")]
		[SerializeField]
		[Min(0f)]
		private float breakDuration;

		[Tooltip("Biên độ punch scale mỗi lần 1 jar clear mà hình chưa tan (giật nhẹ báo tiến độ).")]
		[SerializeField]
		[Min(0f)]
		private float countPunchStrength;

		[Tooltip("Thời gian punch scale (giây).")]
		[SerializeField]
		[Min(0f)]
		private float countPunchDuration;

		[Tooltip("Giá trị _Progress cuối bơm xuống material model ở bước CUỐI — reveal crack chạy 0..maxBreakProgress, chia đều theo số bước.")]
		[SerializeField]
		[Min(0f)]
		private float maxBreakProgress;

		[Tooltip("Hệ particle bắn khi hình VỠ (bước cuối). Bỏ trống -> chỉ ẩn model, không có particle.")]
		[SerializeField]
		private ParticleSystem breakEffect;

		[Tooltip("Mesh/model thân băng — VỠ = SetActive(false) tức thì (particle che chỗ). Setup bật lại cho pool-reuse.")]
		[SerializeField]
		private GameObject model;

		public Renderer renderer;

		public TMP_Text stepDoneText;

		public Transform scaleObj;

		public Transform breakedTarget;

		public MMF_Player punchFb;

		private int _totalSteps;

		private int _stepDone;

		private Vector3 _baseScale;

		private float _baseStartSize;

		private float _refBaseScaleX;

		private float _clipWorldY;

		private bool _shattered;

		private Vector3 _baseTextScale;

		private bool _baseTextScaleCached;

		private static readonly int ClipWorldYId;

		private Renderer[] _clipRenderers;

		private MaterialPropertyBlock _mpb;

		private static readonly int BreakProgressId;

		public override Vector3 BreakedTargetPosition => default;

		public override void SetClipWorldY(float worldY)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public override void ApplyBaseScale(Vector3 localScale)
		{
		}

		public override void Setup(int totalStepToBreak)
		{
		}

		public override bool PlayBroke()
		{
			return false;
		}

		private void RefreshStepText()
		{
		}

		private void ApplyBreakProgress()
		{
		}

		private void ApplyTextScale()
		{
		}

		private void UpdateStepTextVisibility()
		{
		}

		private void PlayPunch()
		{
		}

		private void PlayShatter()
		{
		}

		private float ResolveDespawnDelay()
		{
			return 0f;
		}
	}
}
