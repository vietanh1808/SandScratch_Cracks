using System;
using System.Collections.Generic;
using JoyCraftSDK.TrophyRoom;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedTrophyRoomData : JSaveData
	{
		public const int MaxVersion_SavedTrophyRoomData = 2;

		[SerializeField]
		private List<int> ownedItemIds;

		[SerializeField]
		private bool starBackfillDone;

		[SerializeField]
		private int lastPaidLevel;

		[SerializeField]
		private TrophyRoomPendingCompletion pendingCompletion;

		[SerializeField]
		private bool hasVisited;

		public bool StarBackfillDone => false;

		public int OwnedCount => 0;

		public int LastPaidLevel => 0;

		public TrophyRoomPendingCompletion PendingCompletion => null;

		public bool HasVisited => false;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override bool UpdateVersionIncremental(int currentVersion)
		{
			return false;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public bool IsOwned(int id)
		{
			return false;
		}

		public void MarkOwned(int id)
		{
		}

		public void MarkStarBackfillDone()
		{
		}

		public void SetLastPaidLevel(int level)
		{
		}

		public void SetPendingCompletion(int roomId, List<TrophyRoomReward> grantedRewards)
		{
		}

		public void ClearPendingCompletion()
		{
		}

		public void MarkVisited()
		{
		}

		public void DebugReset()
		{
		}
	}
}
