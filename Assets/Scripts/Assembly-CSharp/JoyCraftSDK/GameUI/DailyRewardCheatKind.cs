using System;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public enum DailyRewardCheatKind
	{
		ShiftDays = 0,
		ResetCycle = 1,
		JumpToLastSlot = 2,
		ForceTimeRollback = 3,
		OpenPopup = 4
	}
}
