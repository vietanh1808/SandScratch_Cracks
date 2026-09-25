using JoyCraftSDK.Game.SandSimulation;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class SandSwipeController : JMonoBehaviour
	{
		[Header("Refs")]
		[SerializeField]
		private SandField sandField;

		[Tooltip("(swipe-throttle 2026-07-25) Backend cát — đọc LiveGrainCount để CHẶN swipe khi hạt sống quá dày (GrainThrottleEntry/Exit ở bundle). Bỏ trống -> KHÔNG throttle (swipe tự do như cũ).")]
		[SerializeField]
		private GrainFlowBackend grainBackend;

		[Tooltip("(swipe-throttle) Bundle config cát — đọc nhóm Tuning (GrainThrottleEntry/Exit). Gán CÙNG asset với GrainFlowBackend/ConversionFront. Bỏ trống -> KHÔNG throttle.")]
		[SerializeField]
		private SandFlowConfig sandFlowConfig;

		[Header("Swipe")]
		[Tooltip("Bán kính brush theo cell (0 = 1 ô).")]
		[SerializeField]
		private int brushRadius;

		[Tooltip("Chặn swipe khi có panel ở layer Flow/Tutorial/Top (giống RaycastController).")]
		[SerializeField]
		private bool respectUIPanels;

		[Tooltip("(touch FX) Hiệu ứng nảy khi CHẠM mà tap KHÔNG cào trúng pixel tranh (carved==0). Bỏ trống -> tắt FX.")]
		[SerializeField]
		private TouchFxController touchFx;

		private bool _pressing;

		private Vector2Int _lastCell;

		private bool _swipeLocked;

		private bool _throttled;

		private bool _throttleNotified;

		[Header("Obi Mode (Obi-Fluid-Mode-Plan §5 WP-A)")]
		[Tooltip("Builder tranh Obi. Gán -> khi nó Build (Obi mode), swipe route carve sang đây thay path grid. Bỏ trống hoặc chưa Build -> swipe giữ hành vi grid mode.")]
		[SerializeField]
		private PictureColliderBuilder _obiPictureCarve;

		[Tooltip("MỐC RÌA CÀO (2026-08-04): phần BÁN KÍNH brush được phép vượt mép field trước khi nhát cào ngừng cào. 0 = mốc TÂM (tâm qua mép là ngừng cào) · 0.5 = tâm + NỬA đĩa · 1 = cả đĩa phải ra hẳn. CHỈ áp cho việc CÀO dải sát mép — luật ĐÓNG TÚI đi theo dấu chân đĩa (BrushFootprintFullyLiveAtCell), KHÔNG đọc knob này.")]
		[Range(0f, 1f)]
		[SerializeField]
		private float carveEdgeMarginRatio;

		private int _emptyStampStreak;

		private bool _strokeCarveRaised;

		private readonly AEventManager.OnSandSwipeStamp _swipeStampEvt;

		public bool IsSwiping => false;

		public bool ExternalBlock { get; set; }

		public bool ScrollBlock { get; set; }

		public bool BoosterBlock { get; set; }

		private int EmptyStampsToClose => 0;

		private int CarveEdgeMarginCells => 0;

		public void SetSwipeLocked(bool locked)
		{
		}

		private void EndStroke()
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

		private void TickSwipe()
		{
		}

		private int Apply(Vector2Int prevCell, Vector2Int cell)
		{
			return 0;
		}

		private int StampAt(int cx, int cy)
		{
			return 0;
		}

		private void UpdateThrottle()
		{
		}

		private bool ShouldBlockSwipe()
		{
			return false;
		}

		private bool InCarveRange(int cx, int cy)
		{
			return false;
		}

		private int TryObiCarve(int cx, int cy)
		{
			return 0;
		}

		private void OnStrokeBegin()
		{
		}

		private void OnStrokeApplied(int carvedCells, Vector2Int cellDelta)
		{
		}

		private void OnStrokeEnd()
		{
		}

		private bool WouldCarvePicture(int cx, int cy)
		{
			return false;
		}
	}
}
