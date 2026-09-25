using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnSpeedUp : JButton
	{
		[Tooltip("Popup mời xem ads đổi thêm giờ speed-up, mở khi quota trong ngày đã hết. None = chưa gán -> báo lỗi.")]
		[SerializeField]
		private UIPanelID outOfTimePanel;

		[Tooltip("Text đếm ngược mm:ss quota còn lại. CHỈ hiện khi đang x2 do NGƯỜI CHƠI bấm; x2 do rule level (ForceSpeedUp) không trừ giờ nên ẩn. Để trống = không hiển thị đếm ngược.")]
		[SerializeField]
		private TMP_Text countdownText;

		private int shownSeconds;

		[Tooltip("Icon đổi theo trạng thái. Để trống nếu nút chỉ dùng text.")]
		[SerializeField]
		private Image icon;

		protected override void OnClick()
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void TickCountdown(ref AEventManager.OnUpdate eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void UpdateCountdown()
		{
		}

		private void UpdateVisual()
		{
		}
	}
}
