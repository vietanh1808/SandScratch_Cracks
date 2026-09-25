using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class PictureBaselineLine : JMonoBehaviour
	{
		private const string Group_Look = "Look";

		private const string Group_Layout = "Layout";

		[Tooltip("Màu lúc BÌNH THƯỜNG (không vuốt, không tụt).")]
		[SerializeField]
		private Color idleColor;

		[Tooltip("Màu khi ĐANG vuốt hoặc tranh ĐANG tụt. HDR: đẩy intensity > 1 để ăn bloom (nếu post-process có bloom).")]
		[ColorUsage(true, true)]
		[SerializeField]
		private Color activeColor;

		[Tooltip("Thời gian fade giữa 2 màu (giây). 0 -> đổi tức thì (sẽ NHÁY vì scroll đứng-rồi-chạy-tiếp theo thiết kế g3).")]
		[SerializeField]
		private float colorFadeDuration;

		[Tooltip("Optional: material cho LineRenderer. Bỏ trống -> tự sinh material từ shader \"Sprites/Default\" (nhân vertex-color nên 2 màu trên vẫn ăn).")]
		[SerializeField]
		private Material lineMaterial;

		[Tooltip("Sorting layer của line (theo tên layer trong Tags & Layers).")]
		[SerializeField]
		private string sortingLayerName;

		[Tooltip("Sorting order — tăng lên nếu line bị tranh/khung che.")]
		[SerializeField]
		private int sortingOrder;

		[Tooltip("Độ dày line (đơn vị WORLD).")]
		[SerializeField]
		private float lineWidth;

		[Tooltip("Khoảng cách từ đáy tranh XUỐNG tới line (world). 0 = dính sát mép đáy.")]
		[SerializeField]
		private float yOffset;

		[Tooltip("Nới/thu bề ngang line so với W tranh (world, mỗi đầu). 0 = đúng bằng W tranh.")]
		[SerializeField]
		private float widthPadding;

		[Tooltip("Đẩy line ra trước/sau theo trục Z so với mặt phẳng tranh (world). Âm = về phía camera.")]
		[SerializeField]
		private float zOffset;

		private SandSwipeController _sandSwipeController;

		private LineRenderer _line;

		private GameObject _lineObject;

		private Material _runtimeMaterial;

		private Color _currentColor;

		public void Configure(PictureColliderBuilder pictureCarve, SandSwipeController sandSwipeController, Transform parent)
		{
		}

		public void Clear()
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

		private void OnUpdateEvent(ref AEventManager.OnUpdate eventData)
		{
		}

		private void BuildLine(Transform parent)
		{
		}

		private Material ResolveMaterial()
		{
			return null;
		}

		private void ApplyColor(Color color)
		{
		}
	}
}
