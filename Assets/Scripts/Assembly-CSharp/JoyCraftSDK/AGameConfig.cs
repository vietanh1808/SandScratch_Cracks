using JoyCraftSDK.DailyReward;
using JoyCraftSDK.ExternalLink;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.IAP;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Notification;
using JoyCraftSDK.RateApp;
using JoyCraftSDK.RemoteConfig;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using JoyCraftSDK.WinStreak;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class AGameConfig : JScriptableObject
	{
		private const string Group_UI = "UI Configs";

		private const string Group_Gameplay = "Gameplay Configs";

		private const string Group_Data = "Data & Backend";

		[SerializeField]
		public SavedGameDataContainer defaultSavedGameData;

		[SerializeField]
		public AUIConfig gameUIConfig;

		[SerializeField]
		public AUIConfig testUIConfig;

		[SerializeField]
		public AUIConfig gameOverlayUIConfig;

		[SerializeField]
		public AShopContentConfig shopContentConfig;

		[SerializeField]
		public AIAPGroupConfig iapGroupConfig;

		[SerializeField]
		public AIAPEntitlementConfig iapEntitlementConfig;

		[SerializeField]
		public AUnlockTable unlockTable;

		[SerializeField]
		public AUnlockFeatureConfig unlockFeatureConfig;

		[SerializeField]
		public ABoosterConfig boosterConfig;

		[SerializeField]
		public FirebaseRemoteConfigData firebaseRemoteConfigData;

		[SerializeField]
		public ALevelDatabase normalLevelDatabase;

		[SerializeField]
		public ALevelDatabase hardLevelDatabase;

		[SerializeField]
		public ATimedRegenConfig timedRegenConfig;

		[SerializeField]
		public ATimedBuffConfig timedBuffConfig;

		[SerializeField]
		public ARateAppConfig rateAppConfig;

		[SerializeField]
		public ABattlePassConfig battlePassConfig;

		[SerializeField]
		public AWinStreakConfig winStreakConfig;

		[SerializeField]
		public ADailyRewardConfig dailyRewardConfig;

		[SerializeField]
		public ATrophyRoomConfig trophyRoomConfig;

		[SerializeField]
		public ARewardVisualConfig rewardVisualConfig;

		[SerializeField]
		public AProfileVisualConfig profileVisualConfig;

		[SerializeField]
		public ANotificationConfig notificationConfig;

		[SerializeField]
		public AExternalLinkConfig externalLinkConfig;
	}
}
