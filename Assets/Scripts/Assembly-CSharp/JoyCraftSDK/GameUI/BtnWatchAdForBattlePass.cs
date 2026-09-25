using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public class BtnWatchAdForBattlePass : JButton
	{
		private static readonly string Placement;

		private static readonly string RewardType;

		private const int RewardAmount = 1;

		private bool isCanTouch;

		private ABattlePassManager _battlePassManager => null;

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
