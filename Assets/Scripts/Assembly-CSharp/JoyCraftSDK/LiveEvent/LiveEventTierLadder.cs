using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.LiveEvent
{
	public class LiveEventTierLadder : JBase
	{
		private readonly struct TierStep
		{
			public readonly int Tier;

			public readonly int StepCost;

			public readonly int UnlockCost;

			public TierStep(int tier, int stepCost, int unlockCost)
			{
				Tier = 0;
				StepCost = 0;
				UnlockCost = 0;
			}
		}

		private readonly List<TierStep> _tierSteps;

		public LiveEventTierLadder(IReadOnlyList<LiveEventMilestoneEntry> milestoneEntries)
		{
		}

		public bool IsTierUnlocked(int tier, int earned)
		{
			return false;
		}

		public int GetTierStepCost(int tier)
		{
			return 0;
		}

		public int GetTierUnlockCost(int tier)
		{
			return 0;
		}

		public bool TryGetNextLockedTier(int earned, out int tier, out int stepCost, out int stepProgress)
		{
			tier = default;
			stepCost = default;
			stepProgress = default;
			return false;
		}

		private void Build(IReadOnlyList<LiveEventMilestoneEntry> milestoneEntries)
		{
		}
	}
}
