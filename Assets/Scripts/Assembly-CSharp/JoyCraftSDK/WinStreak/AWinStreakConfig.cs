using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.WinStreak
{
	public abstract class AWinStreakConfig : JScriptableObject
	{
		public abstract int ActivationThreshold { get; }

		public abstract int ActivationLevel { get; }

		public abstract int MaxTierStreak { get; }

		public abstract int GetFeatureStreak(int winStreak, int level);

		public abstract IReadOnlyList<BoosterReward> GetRewards(int winStreak);

		public abstract Color GetIconColor(int winStreak);

		public abstract bool HasTierAt(int streak);

		public abstract WinStreakBarState GetBarState(int winStreak, bool boundaryBelongsToCompleted);
	}
}
