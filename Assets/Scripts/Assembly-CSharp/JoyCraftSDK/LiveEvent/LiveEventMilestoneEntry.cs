using System;
using System.Collections.Generic;
using JoyCraftSDK.IAP;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.LiveEvent
{
	[Serializable]
	public class LiveEventMilestoneEntry
	{
		[Tooltip("Id STABLE của mốc — ghi vào save khi claim; CẤM đổi/reuse sau ship.")]
		[SerializeField]
		private int milestoneId;

		[Tooltip("Các phần thưởng của mốc. Rỗng hoặc có kind=None = entry hỏng — track chặn claim TRƯỚC khi trừ (F3).")]
		[SerializeField]
		private List<LiveEventReward> rewards;

		[Tooltip("Icon hiển thị trong Ô khi mốc có NHIỀU reward — MỖI mốc 1 sprite RIÊNG (CTO chốt 2026-08-17), KHÔNG suy từ reward nào. Mốc 1 reward: bỏ trống, icon tra RewardVisualConfig theo kind.")]
		[SerializeField]
		private Sprite multiRewardIcon;

		[HideInInspector]
		[SerializeField]
		private RewardKind kind;

		[HideInInspector]
		[SerializeField]
		private int amount;

		[HideInInspector]
		[SerializeField]
		private int tier;

		[HideInInspector]
		[SerializeField]
		private bool isPremium;

		[FormerlySerializedAs("unlockCost")]
		[HideInInspector]
		[SerializeField]
		private int stepCost;

		public int MilestoneId => 0;

		public int Tier => 0;

		public int StepCost => 0;

		public IReadOnlyList<LiveEventReward> Rewards => null;

		public Sprite MultiRewardIcon => null;

		public bool IsPremium => false;

		public bool IsAuthored => false;

		public string SummaryLabel => null;

		public LiveEventMilestoneEntry()
		{
		}

		public LiveEventMilestoneEntry(int milestoneId, int stepCost, RewardKind kind, int amount, bool isPremium = false, int tier = 0)
		{
		}

		public LiveEventMilestoneEntry(int milestoneId, int stepCost, List<LiveEventReward> rewards, bool isPremium = false, int tier = 0)
		{
		}

		public bool SetSlotIdentity(int tier, bool isPremium, int stepCost)
		{
			return false;
		}

		public bool HasValidRewards()
		{
			return false;
		}

		public bool MigrateLegacy()
		{
			return false;
		}
	}
}
