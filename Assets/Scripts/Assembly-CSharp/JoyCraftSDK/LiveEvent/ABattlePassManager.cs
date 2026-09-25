using System.Collections.Generic;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ABattlePassManager : ALiveEventManager
	{
		public abstract int KeyEarned { get; }

		public abstract bool IsPremiumUnlocked { get; }

		public abstract bool IsInPreviewWindow { get; }

		public abstract IReadOnlyList<LiveEventMilestoneEntry> Milestones { get; }

		public abstract IReadOnlyList<LiveEventMilestoneTier> Tiers { get; }

		public abstract string PremiumProductID { get; }

		public abstract bool IsAdGated { get; }

		public abstract BattlePassNextTier GetNextTier();

		public abstract bool IsClaimed(int milestoneId);

		public abstract void UnlockPremium();

		public abstract void DebugAddKey(int amount);

		public abstract void DebugClearClaimed();

		public abstract bool IsAdGateSlot(int milestoneId);

		public abstract void RedeemAdGate();
	}
}
