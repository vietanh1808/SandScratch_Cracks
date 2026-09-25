using System;
using JoyCraftSDK.IAP;
using UnityEngine;

namespace JoyCraftSDK.LiveEvent
{
	[Serializable]
	public class LiveEventReward
	{
		[Tooltip("Loại thưởng. None = entry hỏng — track chặn claim TRƯỚC khi trừ (F3).")]
		[SerializeField]
		private RewardKind kind;

		[Tooltip("Số lượng. Riêng InfiniteHeart = số PHÚT buff.")]
		[SerializeField]
		private int amount;

		public RewardKind Kind => RewardKind.None;

		public int Amount => 0;

		public LiveEventReward()
		{
		}

		public LiveEventReward(RewardKind kind, int amount)
		{
		}
	}
}
