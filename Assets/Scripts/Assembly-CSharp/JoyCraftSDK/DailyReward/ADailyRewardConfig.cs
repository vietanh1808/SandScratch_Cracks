using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.DailyReward
{
	public abstract class ADailyRewardConfig : JScriptableObject
	{
		public const int SlotCount = 7;

		private const string Group_Gate = "Gate";

		private const string Group_Rewards = "Bảng thưởng — 1 phần tử = 1 NGÀY (index 0 = Day 1)";

		[Tooltip("Feature-gate: Daily Reward chỉ mở khi Level người chơi ≥ giá trị này. 0 = mở ngay từ đầu.")]
		[SerializeField]
		private int unlockAtLevel;

		[Tooltip("Đúng 7 phần tử, theo thứ tự Day 1 → Day 7. Thiếu/thừa = fail-loud lúc author, manager coi như TẮT feature.")]
		[SerializeField]
		private List<DailyRewardSlot> slots;

		public int UnlockAtLevel => 0;

		public bool IsUnlockedAtLevel(int level)
		{
			return false;
		}

		public bool IsValid()
		{
			return false;
		}

		public DailyRewardSlot GetSlot(int slotIndex)
		{
			return null;
		}
	}
}
