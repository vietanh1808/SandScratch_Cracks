using JoyCraftSDK.Game.SandSimulation;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class PictureScrollController : JMonoBehaviour
	{
		private const string Group_Config = "Config";

		[Tooltip("Bundle 3 config hệ cát — đọc GrainScrollRowsPerSecond (tốc độ tụt) + GrainParticleRadius (margin dải gác g3) + GrainScrollClearGrainMax (số hạt còn được phép trong cửa sổ mà vẫn tụt). Phải là CÙNG asset với GrainFlowBackend/LevelSpawner. Bỏ trống -> KHÔNG scroll (báo lỗi).")]
		[SerializeField]
		private SandFlowConfig sandFlowConfig;

		[Tooltip("Prefab rèm cửa (visual). Spawn 1 cái/cột lên scene, đặt ở đỉnh cửa sổ cột, gear cuốn bám s_i của cột. Bỏ trống -> không có rèm.")]
		[SerializeField]
		private Curtain curtainPrefab;

		[Tooltip("(SCROLL CURL) Prefab dải tranh CUỘN NGƯỢC đặt phía TRÊN cửa sổ chơi. Spawn 1 cái/cột ở mép trên cửa sổ, ĐỨNG YÊN — nội dung trượt qua nó theo s_i. Bỏ trống -> không có dải cuộn.")]
		[SerializeField]
		private AScrollCurl curlPrefab;

		[Tooltip("(SCROLL CURL) x = số HÀNG PIXEL tranh (mechanic) hiển thị trên dải cuộn. 0 -> tắt hẳn dải cuộn. Knob đặt ở ĐÂY chứ không ở PixelLevelData để KHÔNG bị WipeLevelFeatureData xoá mỗi lần Convert lại PNG.")]
		[SerializeField]
		private int curlBandRows;

		private PixelLevelData _pixelLevelData;

		private SandField _sandField;

		private GrainFlowBackend _grainBackend;

		private SandSwipeController _sandSwipeController;

		private LevelSpawner _levelSpawner;

		private PictureColliderBuilder _pictureCarve;

		private float[] _scrollRows;

		private int[] _bakedRows;

		private int[] _columnPxMin;

		private int[] _columnPxMax;

		private int _columnCount;

		private int _pictureHeight;

		private int _viewportHeight;

		private float _cellWorldSize;

		private float _scrollMax;

		private float _scrollBaseline;

		private Curtain[] _curtains;

		private ScrollCurlBand[] _curlBands;

		private AScrollCurl[] _curls;

		private bool _columnVisualsSpawned;

		private GrainTuningConfig TuningConfig => null;

		public float ScrollRowsOf(int col)
		{
			return 0f;
		}

		public int BakedRowsOf(int col)
		{
			return 0;
		}

		public void Configure(PixelLevelData pixelLevelData, float cell, SandField sandField, GrainFlowBackend grainBackend, SandSwipeController sandSwipeController, LevelSpawner levelSpawner)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnUpdateEvent(ref AEventManager.OnUpdate eventData)
		{
		}

		private void TickScroll()
		{
		}

		private bool TickColumn(PictureCarveModel model, int col, float maxStep)
		{
			return false;
		}

		private float ResolveTarget(int col, int bottomSolidRow)
		{
			return 0f;
		}

		private bool IsColumnWindowClear(int col)
		{
			return false;
		}

		private void PushScroll(int col, float scrollRows)
		{
		}

		private void SpawnColumnVisuals()
		{
		}

		private void ClearColumnVisuals()
		{
		}
	}
}
