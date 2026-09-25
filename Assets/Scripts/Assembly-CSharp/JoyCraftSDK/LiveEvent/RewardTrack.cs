using System.Collections.Generic;
using JoyCraftSDK.Rewards;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.LiveEvent
{
	public class RewardTrack : JBase
	{
		private readonly IReadOnlyList<LiveEventMilestoneEntry> _milestoneEntries;

		private readonly TrackMode _trackMode;

		private readonly SavedTrackData _savedTrackData;

		private readonly IProgressSource _progressSource;

		private readonly ALiveEventEntitlement _entitlement;

		private readonly RewardGranter _rewardGranter;

		private readonly LiveEventTierLadder _tierLadder;

		public RewardTrack(IReadOnlyList<LiveEventMilestoneEntry> milestoneEntries, TrackMode trackMode, SavedTrackData savedTrackData, IProgressSource progressSource, ALiveEventEntitlement entitlement, RewardGranter rewardGranter)
		{
		}

		public bool CanClaim(int milestoneId)
		{
			return false;
		}

		public bool IsTierUnlocked(int tier)
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

		public bool TryClaim(int milestoneId)
		{
			return false;
		}

		private bool EvaluateGuards(int milestoneId, bool logFailure, out LiveEventMilestoneEntry entry)
		{
			entry = null;
			return false;
		}

		private bool HasUnclaimedEarlierInLane(LiveEventMilestoneEntry entry)
		{
			return false;
		}

		private LiveEventMilestoneEntry FindEntry(int milestoneId)
		{
			return null;
		}
	}
}
