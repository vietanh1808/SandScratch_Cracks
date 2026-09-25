using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BtnClaimDailyReward : JButton
	{
		[FormerlySerializedAs("_popup")]
		[SerializeField]
		private PopupDailyReward _popupDailyReward;

		[Tooltip("Optional — swap sprite xám khi hôm nay đã claim. Để trống nếu prefab chưa dựng.")]
		[SerializeField]
		private Image targetImage;

		[SerializeField]
		private Sprite normalSprite;

		[SerializeField]
		private Sprite disabledSprite;

		public void SetClaimable(bool canClaimToday, bool isBusy)
		{
		}

		protected override void OnClick()
		{
		}
	}
}
