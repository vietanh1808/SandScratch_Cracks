using System;
using System.Collections.Generic;
using JoyCraftSDK.Game.SandSimulation;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	public class PictureColliderBuilder : JMonoBehaviour
	{
		private struct RevertFade
		{
			public int px;

			public int py;

			public float delay;

			public float t;
		}

		[Header("Refs")]
		[Tooltip("SandField mà tranh nằm trên (dùng quad transform + cỡ grid để map cell->local collider).")]
		[SerializeField]
		private SandField sandField;

		[Tooltip("Bundle 3 config hệ cát — builder đọc nhóm Layout (gizmo màu collider đặc PictureGizmoColor + bật/tắt DrawGizmos). Gán CÙNG asset với GrainFlowBackend/ConveyorController/ConversionFront/LevelSpawner.")]
		[SerializeField]
		private SandFlowConfig sandFlowConfig;

		[Header("Occupancy")]
		[Tooltip("Cỡ block occupancy thô theo PIXEL tranh (§0d) mà PictureCarveModel dựng. 4 -> 50×50 (coarse). 1 = per-pixel. ConversionFront clearance-search quét trên grid thô này để tìm chỗ spawn hạt.")]
		[SerializeField]
		[Min(1f)]
		private int occCellPixels;

		[Tooltip("Biên CLEARANCE spawn hạt (world) — ConversionFront cộng vào bán kính khi tìm chỗ hở để phọt hạt (hạt phải cách mép tranh ≥ số này). Xưa là bề dày mép BoxCollider2D thời Obi; pool gỡ 2026-07-25, GIỮ làm knob clearance vì ConversionFront còn đọc. Tên cũ colliderEdgeRadius -> giữ binding qua FormerlySerializedAs.")]
		[FormerlySerializedAs("colliderEdgeRadius")]
		[SerializeField]
		[Min(0f)]
		private float spawnClearanceMargin;

		[Header("Debug wavefront (stand-in WP-D — verify carve mở collider)")]
		[Tooltip("BẬT: tự pop frontier theo đợt (giả lập wavefront WP-D) để thấy collider mở dần + túi kín giữ HELD. WP-D thật sẽ TẮT cái này và tự drive ConvertCell theo gom≤8 + emit.")]
		[SerializeField]
		private bool debugAutoConvert;

		[Tooltip("Giây giữa 2 đợt convert debug (O8 waveInterval mô phỏng).")]
		[SerializeField]
		[Min(0.01f)]
		private float debugWaveInterval;

		[Tooltip("Số cell convert mỗi đợt debug.")]
		[SerializeField]
		[Min(1f)]
		private int debugConvertPerWave;

		[Header("Debug draw (gizmo)")]
		[SerializeField]
		private bool drawGizmos;

		[SerializeField]
		private bool drawConnectedEmpty;

		[Tooltip("Tô cell TRONG SUỐT của tranh (colorId=-1, KHÔNG có collider từ đầu = đúng thiết kế) — verify B1: điểm hạt 'lọt vào tranh' có trùng vùng không màu này không (trùng = không phải bug collider).")]
		[SerializeField]
		private bool drawTransparentHoles;

		[SerializeField]
		private Color transparentHoleColor;

		[SerializeField]
		private Color solidColor;

		[SerializeField]
		private Color heldColor;

		[SerializeField]
		private Color connectedColor;

		[Header("Debug build (WP-A standalone)")]
		[Tooltip("Level để test carve trong Play mode (Inspector). Runtime thật: WP-B gọi Build(pixelData, rect).")]
		[SerializeField]
		private LevelData debugLevel;

		[Tooltip("Rect ô vuông tranh trong cell-space (khớp LevelSpawner: x=frameLeft+wall, y=boxBottom, w=pw, h=ph). Standalone test tự điền cho khớp; runtime WP-B truyền vào Build.")]
		[SerializeField]
		private RectInt debugPictureCellRect;

		private const byte HeldAlpha = 204;

		private PictureCarveModel _model;

		private RectInt _pictureCellRect;

		private bool _built;

		private readonly List<int> _carveScratch;

		private float _convAccum;

		private bool _scrollEnabled;

		private int _scrollViewportHeight;

		private int _scrollBandHeight;

		private int _scrollColumnCount;

		private float[] _scrollRows;

		private bool[] _scrollingColumns;

		private Func<int, int, bool> _canCarveCell;

		private int _revealVersion;

		private bool _frozenEnabled;

		private readonly List<int> _thinSeeds;

		private readonly HashSet<int> _thinSeen;

		private readonly Queue<int> _thinBfs;

		private readonly List<int> _thinDepth;

		private static readonly int[] NX4;

		private static readonly int[] NY4;

		private static readonly int[] AxisX;

		private static readonly int[] AxisY;

		private const int MaxQueuedBatches = 8;

		private const int DefaultSlabCells = 3;

		private bool _queueWarned;

		private SwipeBatch _openBatch;

		private readonly Queue<SwipeBatch> _closedBatches;

		private readonly Queue<SwipeBatch> _thinBatches;

		private readonly Queue<SwipeBatch> _autoBatches;

		private readonly Stack<SwipeBatch> _batchPool;

		private readonly HashSet<int> _retryCellsSwipe;

		private readonly HashSet<int> _retryCellsThin;

		private readonly HashSet<int> _retryCellsAuto;

		private int _retryLoggedCountSwipe;

		private int _retryLoggedCountThin;

		private int _retryLoggedCountAuto;

		private float _strokeArc;

		private int _lastCarveX;

		private int _lastCarveY;

		private readonly List<RevertFade> _revertFades;

		private AFrozenShapeLibrary FrozenLibrary => null;

		private GrainTuningConfig TuningConfig => null;

		public PictureCarveModel Model => null;

		public bool IsBuilt => false;

		public RectInt PictureCellRect => default;

		private int ThinStripCells => 0;

		private int ThinStripMaxCells => 0;

		private int SlabCells => 0;

		public bool HasOpenBatch => false;

		public bool HasClosedBatch => false;

		public int RetryPendingCount => 0;

		public bool HasAutoBatch => false;

		public bool HasThinBatch => false;

		private HeldRevertStyle RevertStyle => HeldRevertStyle.Snap;

		private float RevertDuration => 0f;

		public int ViewScale => 0;

		public int RevealVersion => 0;

		public float SpawnClearanceMargin => 0f;

		public void Build(PixelLevelData pixelLevelData, RectInt pictureCellRect, int exitMinPx = -1, int exitMaxPx = -1, bool scrollEnabled = false, bool frozenEnabled = false)
		{
		}

		private void RasterFrozenShapes(PixelLevelData pixelLevelData)
		{
		}

		public void UnfreezeGroup(int groupId)
		{
		}

		private void DebugBuild()
		{
		}

		public void BuildCentered(PixelLevelData pixelLevelData, bool scrollEnabled = false, bool frozenEnabled = false)
		{
		}

		public void BuildCentered(PixelLevelData pixelLevelData, bool restrictToThroat, Vector2 mouthWorldCenter, float mouthHalfWidth, bool scrollEnabled = false, bool frozenEnabled = false)
		{
		}

		private void ComputeThroatExitRange(RectInt rect, PixelLevelData pixelLevelData, Vector2 mouthWorldCenter, float mouthHalfWidth, out int exitMinPx, out int exitMaxPx)
		{
			exitMinPx = default;
			exitMaxPx = default;
		}

		public void Clear()
		{
		}

		public int CarveAtCell(int cellX, int cellY, int radius)
		{
			return 0;
		}

		public bool TryCellToPictureLocal(int cellX, int cellY, out int px, out int py)
		{
			px = default;
			py = default;
			return false;
		}

		public bool WouldCarveSolid(int cellX, int cellY, int radius)
		{
			return false;
		}

		public int CarveAllRemaining()
		{
			return 0;
		}

		public int CarveAllRemainingOfColor(int colorId)
		{
			return 0;
		}

		private int FinishAutoSwipeBatch()
		{
			return 0;
		}

		public void EnqueueRetryBatch(IReadOnlyList<int> cells, SwipeBatchChannel channel)
		{
		}

		private HashSet<int> RetryBookOf(SwipeBatchChannel channel)
		{
			return null;
		}

		private SwipeBatch BuildRetryBatch(SwipeBatchChannel channel)
		{
			return null;
		}

		private void LogRetryBookSize(SwipeBatchChannel channel, int count)
		{
		}

		private void EnqueueCellsAsBatch(IReadOnlyList<int> cells, Queue<SwipeBatch> queue)
		{
		}

		private Queue<SwipeBatch> QueueOf(SwipeBatchChannel channel)
		{
			return null;
		}

		public int EnqueueThinStripBatch(IReadOnlyList<int> batchCells)
		{
			return 0;
		}

		private void TryPushThin(int px, int py, int depth, int w, int thin, int cap)
		{
		}

		private bool IsThinAt(int px, int py, int thin)
		{
			return false;
		}

		private int SolidRun(int px, int py, int sx, int sy, int cap)
		{
			return 0;
		}

		public bool BrushOverlapsOpenBatchAtCell(int cellX, int cellY, int radius)
		{
			return false;
		}

		public bool BrushFootprintFullyLiveAtCell(int cellX, int cellY, int radius)
		{
			return false;
		}

		public void CloseSwipeBatch()
		{
		}

		public bool TryDequeueClosedBatch(out SwipeBatch batch)
		{
			batch = null;
			return false;
		}

		public bool TryDequeueAutoBatch(out SwipeBatch batch)
		{
			batch = null;
			return false;
		}

		public bool TryDequeueThinBatch(out SwipeBatch batch)
		{
			batch = null;
			return false;
		}

		public void ReleaseBatch(SwipeBatch batch)
		{
		}

		private void AppendToOpenBatch()
		{
		}

		private bool BrushOverlapsOpenBatch(int px, int py, int radius)
		{
			return false;
		}

		private bool BrushFootprintFullyLive(int px, int py, int radius)
		{
			return false;
		}

		private void AdvanceStrokeArc(int px, int py)
		{
		}

		private void ResetStrokeArc()
		{
		}

		private void DropAllBatches()
		{
		}

		public void RestoreVisualCell(int px, int py, float orderT)
		{
		}

		private void TickRevertFades()
		{
		}

		private void WriteCellAlpha(int px, int py, byte alpha)
		{
		}

		private int FirstCarvableRow(int col)
		{
			return 0;
		}

		private bool CanCarveCell(int px, int py)
		{
			return false;
		}

		public bool IsCellRevealed(int px, int py)
		{
			return false;
		}

		private int ResolveViewScale()
		{
			return 0;
		}

		private static int FloorDiv(int a, int b)
		{
			return 0;
		}

		private void DimCarvedVisual()
		{
		}

		public Vector3 PictureCellToWorld(int px, int py)
		{
			return default;
		}

		public Vector3 PictureCellToWorld(float fx, float fy)
		{
			return default;
		}

		private Vector3 PictureCellToWorldInColumn(int col, float fx, float fy)
		{
			return default;
		}

		private int ColumnOfPictureX(float fx)
		{
			return 0;
		}

		public void SetColumnScrollRows(int col, float scrollRows)
		{
		}

		public void SetColumnScrolling(int col, bool scrolling)
		{
		}

		public float PicturePixelWorldSize()
		{
			return 0f;
		}

		public Vector3 PictureDownWorldDir()
		{
			return default;
		}

		public bool TryGetPictureWorldRect(out Vector3 worldCenter, out Vector2 worldSize)
		{
			worldCenter = default;
			worldSize = default;
			return false;
		}

		public bool TryGetVisiblePictureWorldRect(out Vector3 worldCenter, out Vector2 worldSize)
		{
			worldCenter = default;
			worldSize = default;
			return false;
		}

		public void EraseVisualCell(int px, int py)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventData)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
