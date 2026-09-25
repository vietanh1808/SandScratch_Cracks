using System;
using System.Collections.Generic;
using System.Text;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Rewards;
using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.Game
{
	public class Factory : AFactory
	{
		private bool _inited;

		private readonly GameNotificationBootstrap _gameNotificationBootstrap;

		private readonly StringBuilder _stringBuilder;

		public override void Init(Action onComplete = null)
		{
		}

		public override string NewGuid()
		{
			return null;
		}

		public override StringBuilder NewStringBuilder()
		{
			return null;
		}

		public override BoosterShuffle NewBoosterShuffle()
		{
			return null;
		}

		public override BoosterHammer NewBoosterHammer()
		{
			return null;
		}

		public override BoosterBlower NewBoosterBlower()
		{
			return null;
		}

		public override BoosterType4 NewBoosterType4()
		{
			return null;
		}

		public override RewardGranter NewRewardGranter()
		{
			return null;
		}

		public override EventWallet NewEventWallet(SavedWalletIntData savedWalletIntData)
		{
			return null;
		}

		public override RewardTrack NewRewardTrack(IReadOnlyList<LiveEventMilestoneEntry> milestoneEntries, TrackMode trackMode, SavedTrackData savedTrackData, IProgressSource progressSource, ALiveEventEntitlement entitlement, RewardGranter rewardGranter)
		{
			return null;
		}

		public override SaveFlagLiveEventEntitlement NewSaveFlagLiveEventEntitlement(SavedTrackData savedTrackData)
		{
			return null;
		}

		public override NullLiveEventEntitlement NewNullLiveEventEntitlement()
		{
			return null;
		}
	}
}
