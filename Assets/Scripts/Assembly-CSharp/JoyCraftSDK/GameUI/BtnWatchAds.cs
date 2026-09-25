using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnWatchAds : JButton
	{
		[SerializeField]
		private JUIPanel _panel;

		[SerializeField]
		private TxtCoin coinText;

		[SerializeField]
		private AWinFlowController winFlow;

		private int baseCoinAmount;

		private bool isCanTouch;

		private bool resolved;

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

		private void GrantAndGoHome(int multiplier)
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
