using System;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public enum BoosterEarnReason
	{
		None = 0,
		Purchase = 1,
		Iap = 2,
		Reward = 3,
		Unlock = 4,
		DailyGift = 5,
		Seed = 6
	}
}
