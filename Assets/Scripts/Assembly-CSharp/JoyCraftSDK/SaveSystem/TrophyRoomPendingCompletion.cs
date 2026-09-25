using System;
using System.Collections.Generic;
using JoyCraftSDK.TrophyRoom;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class TrophyRoomPendingCompletion
	{
		[SerializeField]
		private int roomId;

		[SerializeField]
		private List<TrophyRoomReward> rewards;

		public int RoomId => 0;

		public IReadOnlyList<TrophyRoomReward> Rewards => null;

		public bool HasPending => false;

		public void Set(int roomId, List<TrophyRoomReward> grantedRewards)
		{
		}

		public void Clear()
		{
		}
	}
}
