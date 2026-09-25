using System;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public enum BattlePassMilestoneState
	{
		Locked = 0,
		Claimable = 1,
		Claimed = 2,
		PremiumLocked = 3,
		AdGated = 4
	}
}
