using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedDailyRewardData : JSaveData
	{
		public const int MaxVersion_SavedDailyRewardData = 1;

		[SerializeField]
		private long cycleStartUtcTicks;

		[SerializeField]
		private long lastClaimUtcTicks;

		[SerializeField]
		private List<int> claimedSlotsInCycle;

		[SerializeField]
		private int cycleCount;

		public long CycleStartUtcTicks => 0L;

		public long LastClaimUtcTicks => 0L;

		public int CycleCount => 0;

		public int ClaimedCountInCycle => 0;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public bool HasCycleStarted()
		{
			return false;
		}

		public bool IsSlotClaimed(int slotIndex)
		{
			return false;
		}

		public void StartNewCycle(long newCycleStartUtcTicks, int cycleIncrement)
		{
		}

		public void MarkSlotClaimed(int slotIndex, long claimUtcTicks)
		{
		}

		public void DebugSetCycleStartUtcTicks(long newCycleStartUtcTicks)
		{
		}

		public void DebugSetLastClaimUtcTicks(long newLastClaimUtcTicks)
		{
		}

		public void DebugResetAll()
		{
		}
	}
}
