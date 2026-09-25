using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.WinStreak
{
	[CreateAssetMenu(fileName = "WinStreakConfig", menuName = "GameSDK/WinStreakConfig")]
	public class WinStreakConfig : AWinStreakConfig
	{
		[Tooltip("Streak tối thiểu để bắt đầu tặng bonus (Butler's Gift: 1 = thưởng ngay sau trận thắng đầu tiên).")]
		[SerializeField]
		private int activationThreshold;

		[Tooltip("Level tối thiểu (1-based) để mở sự kiện Butler's Gift (mặc định 32).")]
		[SerializeField]
		private int activationLevel;

		[Tooltip("Các tier phần thưởng. GetRewards trả tier có minStreak cao nhất mà <= winStreak.")]
		[SerializeField]
		private List<WinStreakRewardTier> tiers;

		[Tooltip("Màu icon trên win-streak bar khi CHƯA đạt tier thưởng nào (trước tier đầu tiên).")]
		[SerializeField]
		private Color noRewardIconColor;

		public override int ActivationThreshold => 0;

		public override int ActivationLevel => 0;

		public override int MaxTierStreak => 0;

		public override int GetFeatureStreak(int winStreak, int level)
		{
			return 0;
		}

		public override bool HasTierAt(int streak)
		{
			return false;
		}

		public override WinStreakBarState GetBarState(int winStreak, bool boundaryBelongsToCompleted)
		{
			return default;
		}

		public override IReadOnlyList<BoosterReward> GetRewards(int winStreak)
		{
			return null;
		}

		private WinStreakRewardTier GetEarnedTier(int winStreak)
		{
			return null;
		}

		public override Color GetIconColor(int winStreak)
		{
			return default;
		}
	}
}
