using System;

namespace JoyCraftSDK.DailyReward
{
	[Serializable]
	public enum DailyRewardSlotState
	{
		Locked = 0,
		Available = 1,
		Claimed = 2,
		Missed = 3
	}
}
