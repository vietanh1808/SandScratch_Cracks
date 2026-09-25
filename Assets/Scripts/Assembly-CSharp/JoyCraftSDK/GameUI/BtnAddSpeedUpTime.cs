using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnAddSpeedUpTime : JButton
	{
		[Tooltip("Số GIÂY speed-up cộng thêm mỗi lần xem xong ads (3600 = 1 giờ).")]
		[SerializeField]
		[Min(1f)]
		private int rewardSeconds;

		[Tooltip("Panel chứa nút này — nhận thưởng xong thì đóng. Để trống = không tự đóng.")]
		[SerializeField]
		private JUIPanel panel;

		[Tooltip("Nhận thưởng xong bật x2 luôn (người chơi bấm xem ads là đang MUỐN tăng tốc).")]
		[SerializeField]
		private bool autoSpeedUpAfterReward;

		private bool isCanClick;

		protected override void OnEnable()
		{
		}

		protected override void OnClick()
		{
		}

		private void OnRewardSuccess()
		{
		}

		private void OnRewardedFailed(ref AEventManager.OnShowRewardedFailed eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
