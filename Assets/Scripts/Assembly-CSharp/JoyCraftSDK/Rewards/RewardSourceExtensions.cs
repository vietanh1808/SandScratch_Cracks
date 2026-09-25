using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Rewards
{
	public static class RewardSourceExtensions
	{
		public static ResourceEarnChannel ToEarnChannel(this RewardSource source)
		{
			return ResourceEarnChannel.None;
		}

		public static BoosterEarnReason ToBoosterReason(this RewardSource source)
		{
			return BoosterEarnReason.None;
		}

		public static AnalyticsPlacement ToPlacement(this RewardSource source)
		{
			return AnalyticsPlacement.None;
		}
	}
}
