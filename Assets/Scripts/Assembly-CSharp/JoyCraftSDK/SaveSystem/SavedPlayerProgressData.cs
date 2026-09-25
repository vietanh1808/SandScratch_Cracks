using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedPlayerProgressData : JSaveData
	{
		public const int MaxVersion_SavedPlayerProgressData = 3;

		private const string Group_Currency = "Currency";

		private const string Group_Progress = "Progress";

		private const string Group_SubData = "Sub Data";

		private const string Group_Analytics = "Analytics";

		[SerializeField]
		private int coin;

		[SerializeField]
		private int gem;

		[SerializeField]
		private int star;

		[SerializeField]
		private int level;

		[SerializeField]
		private int currentLevelAttempt;

		[SerializeField]
		private int currentLevelLoseIndex;

		[SerializeField]
		private int currentLevelExitIndex;

		[SerializeField]
		private float currentLevelDurationTotal;

		[SerializeField]
		private float lastAttemptProgressPosX;

		[SerializeField]
		private int winStreak;

		[SerializeField]
		private int loseStreak;

		[SerializeField]
		private int activeDayCount;

		[SerializeField]
		private string lastActiveDate;

		[SerializeField]
		private int loginStreak;

		[SerializeField]
		private int highestWinStreak;

		[SerializeField]
		private int firstTryWinCount;

		[SerializeField]
		private SavedBoosterData savedBoosterData;

		[SerializeField]
		private SavedFeatureData savedFeatureData;

		[SerializeField]
		private SavedTutorialData savedTutorialData;

		[SerializeField]
		private SavedRegenData savedRegenData;

		[SerializeField]
		private SavedBuffData savedBuffData;

		[SerializeField]
		private SavedRateAppData savedRateAppData;

		[SerializeField]
		private SavedPendingAbandonData savedPendingAbandonData;

		[SerializeField]
		private SavedBattlePassData savedBattlePassData;

		[SerializeField]
		private SavedDailyRewardData savedDailyRewardData;

		[SerializeField]
		private SavedTrophyRoomData savedTrophyRoomData;

		[SerializeField]
		private SavedProfileData savedProfileData;

		[SerializeField]
		private GameTheme selectedGameTheme;

		[SerializeField]
		private SavedLocalizationData savedLocalizationData;

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CompletedLevelCount => 0;

		public int CurrentLevelAttempt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurrentLevelLoseIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurrentLevelExitIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float CurrentLevelDurationTotal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float LastAttemptProgressPosX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int WinStreak
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LoseStreak
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ActiveDayCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string LastActiveDate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LoginStreak
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int HighestWinStreak
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int FirstTryWinCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SavedBoosterData SavedBoosterData => null;

		public SavedFeatureData SavedFeatureData => null;

		public SavedRegenData SavedRegenData => null;

		public SavedBuffData SavedBuffData => null;

		public SavedRateAppData SavedRateAppData => null;

		public SavedPendingAbandonData SavedPendingAbandonData => null;

		public SavedBattlePassData SavedBattlePassData => null;

		public SavedDailyRewardData SavedDailyRewardData => null;

		public SavedTrophyRoomData SavedTrophyRoomData => null;

		public SavedProfileData SavedProfileData => null;

		public SavedLocalizationData SavedLocalizationData => null;

		public SavedTutorialData SavedTutorialData => null;

		public int GetCoin()
		{
			return 0;
		}

		public void SetCoin(int value)
		{
		}

		public int GetGem()
		{
			return 0;
		}

		public void SetGem(int value)
		{
		}

		public int GetStar()
		{
			return 0;
		}

		public void SetStar(int value)
		{
		}

		public GameTheme GetSelectedGameTheme()
		{
			return GameTheme.Theme0;
		}

		public void SetSelectedGameTheme(GameTheme theme)
		{
		}

		public bool IsFTUEDone()
		{
			return false;
		}

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
	}
}
