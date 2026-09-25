using System;
using JoyCraftSDK.IAP;
using UnityEngine;

namespace JoyCraftSDK.TrophyRoom
{
	[Serializable]
	public class TrophyRoomReward
	{
		[SerializeField]
		private RewardKind kind;

		[SerializeField]
		private int amount;

		public RewardKind Kind => RewardKind.None;

		public int Amount => 0;

		public TrophyRoomReward()
		{
		}

		public TrophyRoomReward(RewardKind kind, int amount)
		{
		}
	}
}
