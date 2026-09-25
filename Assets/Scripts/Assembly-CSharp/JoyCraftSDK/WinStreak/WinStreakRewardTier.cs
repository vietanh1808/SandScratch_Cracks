using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.WinStreak
{
	[Serializable]
	public class WinStreakRewardTier
	{
		[Tooltip("Streak tối thiểu để kích hoạt tier này (inclusive).")]
		[SerializeField]
		private int minStreak;

		[Tooltip("Các booster tạm được tặng ở tier này.")]
		[SerializeField]
		private List<BoosterReward> rewards;

		[Tooltip("Màu icon hiển thị cho tier này trên win-streak bar.")]
		[SerializeField]
		private Color iconColor;

		public int MinStreak => 0;

		public IReadOnlyList<BoosterReward> Rewards => null;

		public Color IconColor => default;
	}
}
