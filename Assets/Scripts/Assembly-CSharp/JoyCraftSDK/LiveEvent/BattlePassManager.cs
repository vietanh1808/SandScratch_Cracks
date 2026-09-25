using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.LiveEvent
{
	public class BattlePassManager : ABattlePassManager
	{
		private bool _subscribed;

		private EventWallet _wallet;

		private RewardTrack _track;

		private SaveFlagLiveEventEntitlement _entitlement;

		private SavedBattlePassData savedBattlePassData => null;

		private SavedAdGateData savedAdGateData => null;

		private ABattlePassConfig battlePassConfig => null;

		public override string EventId => null;

		protected override RewardTrack Track => null;

		protected override JSaveData EventSaveData => null;

		public override bool IsActive => false;

		public override bool IsUnlocked => false;

		public override bool IsInPreviewWindow => false;

		public override int KeyEarned => 0;

		public override bool IsPremiumUnlocked => false;

		public override IReadOnlyList<LiveEventMilestoneEntry> Milestones => null;

		public override IReadOnlyList<LiveEventMilestoneTier> Tiers => null;

		public override string PremiumProductID => null;

		public override bool IsAdGated => false;

		private bool IsAdGateApplicable => false;

		public override BattlePassNextTier GetNextTier()
		{
			return default;
		}

		public override bool IsClaimed(int milestoneId)
		{
			return false;
		}

		public override void UnlockPremium()
		{
		}

		public override void DebugAddKey(int amount)
		{
		}

		public override void DebugClearClaimed()
		{
		}

		protected override bool IsClaimGated(int milestoneId)
		{
			return false;
		}

		private bool HasClaimableMilestone()
		{
			return false;
		}

		public override bool IsAdGateSlot(int milestoneId)
		{
			return false;
		}

		private int GetClaimedFreeMilestoneCount()
		{
			return 0;
		}

		public override void RedeemAdGate()
		{
		}

		private bool EnsureInited(string member)
		{
			return false;
		}

		public override void Initialize()
		{
		}

		private void SeedAdGateBaselineOnce()
		{
		}

		private void BuildTrack(SavedBattlePassData battlePassData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnPurchaseSucceeded(string productID)
		{
		}
	}
}
