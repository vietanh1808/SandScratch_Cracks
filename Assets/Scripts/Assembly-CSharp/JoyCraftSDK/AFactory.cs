using System;
using System.Collections.Generic;
using System.Text;
using JoyCraftSDK.Game;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Rewards;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AFactory : JMonoBehaviour
	{
		public abstract void Init(Action onComplete = null);

		public abstract string NewGuid();

		public abstract StringBuilder NewStringBuilder();

		public abstract BoosterShuffle NewBoosterShuffle();

		public abstract BoosterHammer NewBoosterHammer();

		public abstract BoosterBlower NewBoosterBlower();

		public abstract BoosterType4 NewBoosterType4();

		public abstract RewardGranter NewRewardGranter();

		public abstract EventWallet NewEventWallet(SavedWalletIntData savedWalletIntData);

		public abstract RewardTrack NewRewardTrack(IReadOnlyList<LiveEventMilestoneEntry> milestoneEntries, TrackMode trackMode, SavedTrackData savedTrackData, IProgressSource progressSource, ALiveEventEntitlement entitlement, RewardGranter rewardGranter);

		public abstract SaveFlagLiveEventEntitlement NewSaveFlagLiveEventEntitlement(SavedTrackData savedTrackData);

		public abstract NullLiveEventEntitlement NewNullLiveEventEntitlement();
	}
}
