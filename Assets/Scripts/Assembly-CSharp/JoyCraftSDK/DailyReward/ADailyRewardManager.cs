using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.DailyReward
{
	public abstract class ADailyRewardManager : JBase
	{
		public abstract bool IsActive { get; }

		public abstract bool IsUnlocked { get; }

		public abstract int CurrentSlotIndex { get; }

		public abstract int CycleCount { get; }

		public abstract DailyRewardSlotState GetSlotState(int slotIndex);

		public abstract DailyRewardSlot GetSlotRewards(int slotIndex);

		public abstract bool HasAnythingToClaim();

		public abstract TimeSpan TimeUntilNextSlot();

		public abstract bool TryClaimFree(int slotIndex);

		public abstract bool TryClaimMissedAfterAd(int slotIndex);

		public abstract void DebugShiftDays(int dayCount);

		public abstract void DebugResetCycle();

		public abstract void DebugJumpToLastSlot();

		public abstract void DebugForceTimeRollback(int dayCount);

		public abstract string DebugDescribeState();
	}
}
