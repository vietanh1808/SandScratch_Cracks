using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class ObiJarSink : JMonoBehaviour
	{
		[Serializable]
		public class JarMouth
		{
			[Tooltip("Anchor đặt tại MIỆNG jar (world). Hạt đúng màu vào vùng quanh đây -> vào jar.")]
			public Transform anchor;

			[Tooltip("Cỡ vùng miệng (world, XY) quanh anchor — nên ~ bề rộng jar.")]
			public Vector2 size;

			[Tooltip("Màu jar này nhận (== head jar). Chỉ hạt cùng màu bị hút.")]
			public GameObjectColor color;
		}

		[Serializable]
		public class ColumnMouthOverride
		{
			[Tooltip("Index cột (0-based, thứ tự cột trái->phải khớp ColorJarController).")]
			public int columnIndex;

			[Tooltip("Anchor TAY vị trí vùng hút (world) cột này. BỎ TRỐNG -> dùng offset dưới tính từ tâm head.")]
			public Transform anchor;

			[Tooltip("Offset WORLD riêng từ tâm head cột này (chỉ dùng khi anchor trống) — thay autoMouthOffset chung.")]
			public Vector3 offset;

			[Tooltip("BẬT: dùng size riêng bên dưới thay autoMouthSize chung.")]
			public bool useCustomSize;

			[Tooltip("Cỡ vùng hút riêng (world, XY) khi useCustomSize bật.")]
			public Vector2 size;
		}

		private class GrainFlight
		{
			public JarGrainVisual visual;

			public ColorJar targetJar;

			public int colorId;

			public int carried;

			public Vector3 start;

			public Vector3 landJitter;

			public float lateralAmount;

			public float power;

			public float duration;

			public float elapsed;
		}

		[Header("Refs")]
		[Tooltip("Jar controller — nguồn remaining capacity (throttle overshoot §9) + đích cộng count qua seam.")]
		[SerializeField]
		private ColorJarController colorJarController;

		[Header("Auto mouth (theo head jar — khuyên dùng)")]
		[Tooltip("BẬT: tự dò head jar SỐNG từ ColorJarController mỗi frame — vùng hút = tâm head + autoMouthOffset, màu = head.Color -> dồn cột tự đúng màu (hết G2), KHÔNG cần đặt anchor tay (jar spawn runtime). TẮT: dùng list mouths tay bên dưới.")]
		[SerializeField]
		private bool autoMouthFromJars;

		[Tooltip("Offset WORLD từ TÂM head jar tới vùng hút. ⚠ Hạt Obi bị hút TẠI RÃNH ĐÁY belt (cung bay xuống jar là grain VISUAL — G1) -> offset phải nâng vùng hút lên TRÙM RÃNH ĐÁY ngay trên cột jar, KHÔNG phải tại miệng lọ. Chỉnh theo gizmo lúc Play.")]
		[SerializeField]
		private Vector3 autoMouthOffset;

		[Tooltip("Cỡ vùng hút (world, XY) dùng CHUNG mọi cột ở auto mode — rộng ~ bề rộng jar, cao đủ phủ dày rãnh belt.")]
		[SerializeField]
		private Vector2 autoMouthSize;

		[Tooltip("Cỡ vùng hút RIÊNG cho WIDE HEAD (jar chiếm 2 cột — ColorJar.IsWide), tâm = head.position + autoMouthOffset (BỎ QUA columnMouthOverrides). x<=0 -> tự = autoMouthSize.x×2; y<=0 -> tự = autoMouthSize.y.")]
		[SerializeField]
		private Vector2 wideMouthSize;

		[Tooltip("Offset WORLD THÊM cho HEAD 2x2 (ColorJar.IsTall), CỘNG DỒN vào autoMouthOffset — tâm transform box 2x2 thấp hơn NỬA HÀNG so với box thường (xem ColorJarController.JarLocalYZFor) nên vùng hút thường lệch, chỉnh tay trong Inspector cho khớp gizmo lúc Play. Mặc định 0 (chưa tinh chỉnh).")]
		[SerializeField]
		private Vector3 tallMouthOffset;

		[Tooltip("T1 — đặt TAY vị trí/size vùng hút TỪNG cột (columnIndex khớp thứ tự cột trái->phải của ColorJarController); màu + remaining vẫn TỰ theo head jar sống. Cột không có entry dùng autoMouthOffset/autoMouthSize chung. Gizmo override vẽ VÀNG (hộp chung cyan).")]
		[SerializeField]
		private List<ColumnMouthOverride> columnMouthOverrides;

		[Header("Grain arc — cung nhảy visual khi hút (G1)")]
		[Tooltip("Prefab grain (JarGrainVisual + SpriteRenderer, pool qua PoolManager). BỎ TRỐNG -> tắt cung, +count NGAY lúc hút (hành vi cũ).")]
		[SerializeField]
		private JarGrainVisual grainPrefab;

		[Tooltip("Điểm ĐÁP = tâm head jar + offset WORLD này (chỉnh vào MIỆNG lọ, không bay vào tâm). ⚠ Đơn vị WORLD — grid jarMouthOffset/landDepthCells là CELL.")]
		[SerializeField]
		private Vector3 grainLandOffset;

		[Tooltip("Độ vồng DỌC cung (WORLD, +y lên) — khớp cảm giác grid jumpPower nhưng đơn vị world.")]
		[SerializeField]
		[Min(0f)]
		private float grainJumpPower;

		[Tooltip("Vị trí ĐỈNH cung theo tiến trình bay (0..1). <0.5 = vọt sớm rồi hạ dần vào miệng (grid jumpPeakFrac).")]
		[SerializeField]
		[Range(0.05f, 0.95f)]
		private float grainJumpPeakFrac;

		[Tooltip("Thời gian bay 1 grain (giây).")]
		[SerializeField]
		[Min(0.01f)]
		private float grainJumpDuration;

		[Tooltip("TÁCH GRAIN theo cung: jitter ±tỷ lệ độ vồng mỗi grain (0..1) -> bay khác đường, không dính cụm.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainJumpPowerJitter;

		[Tooltip("TÁCH GRAIN theo thời gian: jitter ±tỷ lệ thời gian bay (0..1) -> lệch pha, không đáp cùng lúc.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainJumpDurationJitter;

		[Tooltip("TÁCH GRAIN theo điểm đáp: bán kính (WORLD) rải ngẫu nhiên quanh miệng — grid jumpSpreadCells (cell). Khi grainLandBandWidth > 0 thì field này CHỈ còn là độ DÀY DỌC (±y) của dải.")]
		[SerializeField]
		[Min(0f)]
		private float grainLandSpread;

		[Tooltip("Bề RỘNG dải đáp NGANG (WORLD, dọc trục X) — ướm bằng bề rộng miệng lọ để hạt TƠI RA thành 1 khoảng ngang thay vì tụ 1 điểm. 0 = tán tròn quanh miệng như cũ (dùng grainLandSpread).")]
		[SerializeField]
		[Min(0f)]
		private float grainLandBandWidth;

		[Tooltip("TÁCH THÀNH NHIỀU ĐƯỜNG CONG: số LÀN cung riêng (1 = 1 đường như cũ). Grain vào LẦN LƯỢT từng làn -> vài parabol fan NGANG cạnh nhau rồi hội tụ lại ở miệng jar.")]
		[SerializeField]
		[Min(1f)]
		private int grainArcLanes;

		[Tooltip("Độ FAN NGANG (WORLD) của làn ngoài cùng tại GIỮA cung (0 = mọi làn trùng, như cũ). Lệch vuông góc hướng bay, về 0 ở 2 đầu -> mọi làn vẫn đáp đúng miệng.")]
		[SerializeField]
		[Min(0f)]
		private float grainArcLaneSpread;

		[Tooltip("Jitter ±ngang mỗi grain (WORLD) để hạt CÙNG làn không trùng khít.")]
		[SerializeField]
		[Min(0f)]
		private float grainArcLaneJitter;

		[Tooltip("FpsOpt N0 Lever 2: số grain visual PREWARM sẵn lúc Begin (tránh Instantiate giữa gameplay lúc grain đầu tiên bay). Ring-buffer RIÊNG của sink thay PoolManager Spawn/Despawn — PoolKit (SetActive + BroadCast mỗi hạt) đo tốn ~0.7ms/frame ở tần suất grain visual.")]
		[SerializeField]
		private int grainVisualPrewarm;

		[Header("Mouths tay (fallback khi TẮT auto)")]
		[Tooltip("1 entry / miệng jar đang nhận. Màu = head jar. Dồn cột đổi màu head -> cập nhật color entry tương ứng (hoặc để đủ mọi màu có jar; sink chỉ hút khi remaining>0).")]
		[SerializeField]
		private List<JarMouth> mouths;

		[Header("Debug")]
		[Tooltip("Log ~1 lần/giây mỗi vùng hút: remaining + hạt trong vùng (total/match màu) + đã hút — soi đứt khâu nào khi hạt không vào jar. total=0: hộp lệch chỗ (chỉnh autoMouthOffset trùm rãnh belt); total>0 match=0: lệch colorId; match>0 hút=0: overshoot (carried > remaining).")]
		[SerializeField]
		private bool debugLogScan;

		[Tooltip("Vẽ gizmo vùng hút CẢ khi không chọn object (OnDrawGizmos thay vì Selected).")]
		[SerializeField]
		private bool alwaysDrawGizmos;

		private const int MaxDirectSplitJars = 8;

		private ISandHarvestBackend _backend;

		private bool _running;

		private readonly List<ColorJar> _headsBuffer;

		private readonly List<ObiFlowEmitters.HarvestedGrain> _grainBuffer;

		private readonly List<ObiFlowEmitters.HarvestedGrain> _directBuffer;

		private Func<int, int, DirectJarVerdict> _canAcceptDirect;

		private readonly Dictionary<int, int> _directPending;

		private readonly List<GrainFlight> _flights;

		private readonly Stack<GrainFlight> _flightPool;

		private int _laneCursor;

		private float _nextDebugLogTime;

		private readonly Stack<JarGrainVisual> _visualFree;

		private readonly List<JarGrainVisual> _visualAll;

		private Transform _visualRoot;

		private Transform VisualRoot => null;

		public void Begin(ISandHarvestBackend backend)
		{
		}

		public void StopSink()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private void HarvestAutoMouths()
		{
		}

		private void GetMouthForColumn(int columnIndex, ColorJar head, out Vector3 center, out Vector2 size)
		{
			center = default;
			size = default;
		}

		private Vector2 ResolveWideMouthSize()
		{
			return default;
		}

		private int HarvestMouth(Bounds bounds, ColorJar head, int remaining)
		{
			return 0;
		}

		private void TickDirectToJar()
		{
		}

		private DirectJarVerdict JudgeDirectGrain(int colorId, int carried)
		{
			return DirectJarVerdict.Accept;
		}

		private void DeliverDirect(ObiFlowEmitters.HarvestedGrain grain)
		{
		}

		private void OpenJarForIncoming(ColorJar jar)
		{
		}

		private void CloseJarAfterIncoming(ColorJar jar)
		{
		}

		private void PrewarmVisuals()
		{
		}

		private JarGrainVisual AcquireVisual(Vector3 worldPos)
		{
			return null;
		}

		private void ReleaseVisual(JarGrainVisual visual)
		{
		}

		private void LaunchGrain(ObiFlowEmitters.HarvestedGrain grain, ColorJar head)
		{
		}

		private void TickFlights(float deltaTime)
		{
		}

		private void CancelAllFlights()
		{
		}

		private void DespawnFlight(GrainFlight flight)
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void DrawMouthGizmos()
		{
		}
	}
}
