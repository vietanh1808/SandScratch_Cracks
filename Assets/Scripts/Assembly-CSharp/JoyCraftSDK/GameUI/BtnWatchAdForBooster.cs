using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnWatchAdForBooster : JButton
	{
		[SerializeField]
		private AUIPanel _panel;

		private bool isCanTouch;

		protected override void OnEnable()
		{
		}

		public void RefreshVisibility(BoosterType type)
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

		private void ClosePopup()
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
