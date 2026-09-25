using System;
using JoyCraftSDK.Rewards;
using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.DailyReward
{
	public class DailyRewardManager : ADailyRewardManager
	{
		private RewardGranter _rewardGranter;

		private RewardGranter rewardGranter => null;

		private SavedDailyRewardData savedDailyRewardData => null;

		private ADailyRewardConfig dailyRewardConfig => null;

		public override bool IsActive => false;

		public override bool IsUnlocked => false;

		public override int CurrentSlotIndex => 0;

		public override int CycleCount => 0;

		public override DailyRewardSlotState GetSlotState(int slotIndex)
		{
			return DailyRewardSlotState.Locked;
		}

		public override DailyRewardSlot GetSlotRewards(int slotIndex)
		{
			return null;
		}

		public override bool HasAnythingToClaim()
		{
			return false;
		}

		public override TimeSpan TimeUntilNextSlot()
		{
			return default;
		}

		public override bool TryClaimFree(int slotIndex)
		{
			return false;
		}

		public override bool TryClaimMissedAfterAd(int slotIndex)
		{
			return false;
		}

		private bool CanClaimNow(int slotIndex)
		{
			return false;
		}

		private bool GrantSlot(int slotIndex, string claimChannel)
		{
			return false;
		}

		private bool EnsureCycleFresh()
		{
			return false;
		}

		private int ComputeSlotIndex()
		{
			return 0;
		}

		private int ComputeDaysElapsed(DateTime utcNow)
		{
			return 0;
		}

		private bool IsClockRolledBack()
		{
			return false;
		}

		private bool IsReady()
		{
			return false;
		}

		private static bool IsValidSlotIndex(int slotIndex)
		{
			return false;
		}

		private static DateTime StartOfUtcDay(DateTime utcTime)
		{
			return default;
		}

		public override void DebugShiftDays(int dayCount)
		{
		}

		public override void DebugResetCycle()
		{
		}

		public override void DebugJumpToLastSlot()
		{
		}

		public override void DebugForceTimeRollback(int dayCount)
		{
		}

		public override string DebugDescribeState()
		{
			return null;
		}
	}
}
