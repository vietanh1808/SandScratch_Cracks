using System.Collections.Generic;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Rewards;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.TrophyRoom
{
	public class TrophyRoomManager : ATrophyRoomManager
	{
		private bool _subscribed;

		private RewardGranter _rewardGranter;

		private ReleaseDifficulty _currentLevelDifficulty;

		private bool _difficultyCached;

		private int _cachedLevel;

		private bool _levelCached;

		private RewardGranter rewardGranter => null;

		public override bool IsActive => false;

		public override bool IsUnlocked => false;

		public override IReadOnlyList<TrophyRoomDef> Rooms => null;

		public override TrophyRoomDef CurrentRoom => null;

		public override IReadOnlyList<TrophyItemDef> Items => null;

		public override int OwnedCount => 0;

		public override bool IsAllRoomsComplete => false;

		public override bool HasVisited => false;

		protected virtual ATrophyRoomConfig trophyRoomConfig => null;

		protected virtual SavedTrophyRoomData savedTrophyRoomData => null;

		protected virtual int CurrentPlayerLevel => 0;

		protected virtual int CompletedLevelCount => 0;

		public override int GetStarsForDifficulty(ReleaseDifficulty difficulty)
		{
			return 0;
		}

		public override TrophyRoomDef GetRoom(int roomId)
		{
			return null;
		}

		public override bool IsOwned(int id)
		{
			return false;
		}

		public override int GetOwnedCountInRoom(int roomId)
		{
			return 0;
		}

		public override bool IsRoomComplete(int roomId)
		{
			return false;
		}

		public override TrophyItemDef GetNextItem()
		{
			return null;
		}

		public override bool CanBuyItem(int itemId)
		{
			return false;
		}

		public override bool TryBuyItem(int itemId)
		{
			return false;
		}

		private int GetNextRoomIdAfter(int roomId)
		{
			return 0;
		}

		public override bool TryGetPendingCompletion(out int roomId, out IReadOnlyList<TrophyRoomReward> rewards)
		{
			roomId = default;
			rewards = null;
			return false;
		}

		public override void AcknowledgeRoomCompletion()
		{
		}

		public override void MarkVisited()
		{
		}

		public override void Initialize()
		{
		}

		protected virtual void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		protected virtual void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		protected virtual void RunStarBackfillOnce()
		{
		}

		protected virtual bool IsReady()
		{
			return false;
		}

		protected virtual bool TryGetLevelDifficulty(int level, out ReleaseDifficulty difficulty)
		{
			difficulty = default;
			return false;
		}

		protected virtual int GetStar()
		{
			return 0;
		}

		protected virtual bool SpendStar(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement)
		{
			return false;
		}

		protected virtual void AddStar(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement)
		{
		}

		protected virtual void SaveGame()
		{
		}

		protected virtual void GrantReward(RewardKind kind, int amount)
		{
		}

		protected virtual void PushRewardHold()
		{
		}

		protected virtual void PopRewardHold()
		{
		}

		protected virtual void RaiseTrophyItemPurchased(int itemId, int ownedCount)
		{
		}

		protected virtual void RaiseTrophyRoomCompleted(int roomId, int nextRoomId)
		{
		}

		public override void DebugResetRoom()
		{
		}

		public override string DebugDescribeState()
		{
			return null;
		}
	}
}
