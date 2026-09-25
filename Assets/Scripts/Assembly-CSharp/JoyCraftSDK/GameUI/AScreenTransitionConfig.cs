using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AScreenTransitionConfig : JScriptableObject
	{
		[Header("Màu")]
		[Tooltip("Màu của lớp phủ (veil) che màn hình lúc chuyển. Mặc định lavender #98AFE9. Đổi màu có hiệu lực ngay lần Play kế, không cần recompile.")]
		[SerializeField]
		private Color veilColor;

		[Header("Thời lượng (giây)")]
		[Tooltip("Thời gian ĐÓNG VÀO: lỗ tròn co từ mở-hết về 0 để phủ kín màn. Nhỏ = đóng nhanh/gắt, lớn = đóng chậm/mượt.")]
		[SerializeField]
		private float coverDuration;

		[Tooltip("Thời gian MỞ RA: lỗ tròn nở từ 0 ra hết để lộ màn mới. Nhỏ = bung nhanh, lớn = mở từ tốn.")]
		[SerializeField]
		private float revealDuration;

		[Tooltip("Giữ PHỦ KÍN (lỗ = 0) giữa đóng và mở. PHẢI >= delay build màn kế để mở ra thì level đã dựng xong — win-continue chờ LoadCurrentLevel DoAfterSeconds(0.75s), nên để ~0.6+ (cover 0.26 + hold 0.6 = 0.86 > 0.75). Hạ quá thấp -> thấy board rỗng lúc mở.")]
		[SerializeField]
		private float holdDuration;

		[Header("Hình học lỗ")]
		[Tooltip("Độ MỀM viền lỗ tròn (đơn vị chuẩn-hoá theo chiều cao màn). 0 = viền cứng/răng cưa, lớn = viền loang mờ. ~0.02 cho mép mềm nhẹ như video.")]
		[SerializeField]
		private float softEdge;

		[Tooltip("Biên AN TOÀN để lúc lỗ mở hết vẫn trong suốt tới tận GÓC màn (không sót màu ở góc). Tăng nếu thấy viền màu còn dính ở góc lúc mở xong.")]
		[SerializeField]
		private float coverMargin;

		[Header("Render")]
		[Tooltip("Thứ tự vẽ của Canvas transition. Để cao (30000) cho veil nằm TRÊN mọi UI khác (Popup/Loading/Effect). Chỉ đổi nếu cần chèn dưới 1 lớp UI nào đó.")]
		[SerializeField]
		private int sortingOrder;

		[Tooltip("Shader khoét lỗ iris — kéo asset ScreenTransitionIris.shader vào đây. Tham chiếu ASSET (không tra theo tên) nên build tự kéo shader theo, KHÔNG cần thêm vào Always Included Shaders. Bỏ trống -> fallback UI/Default: veil phủ kín, mất hiệu ứng lỗ tròn.")]
		[SerializeField]
		private Shader irisShader;

		public Color VeilColor => default;

		public float CoverDuration => 0f;

		public float RevealDuration => 0f;

		public float SoftEdge => 0f;

		public float CoverMargin => 0f;

		public float HoldDuration => 0f;

		public int SortingOrder => 0;

		public Shader IrisShader => null;
	}
}
