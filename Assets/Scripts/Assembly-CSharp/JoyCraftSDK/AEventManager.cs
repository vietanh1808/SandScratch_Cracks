using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AEventManager : JMonoBehaviour
	{
		public class OnFeatureUnlocked : IEvent
		{
			public string featureName;

			public string unlockMethod;

			public int userLevel;
		}

		public class OnPowerUpBought : IEvent
		{
			public BoosterType type;

			public int quantity;
		}

		public class OnOutGame : IEvent
		{
			public int totalLevel;

			public string location;
		}

		public class OnScreenView : IEvent
		{
			public string screenName;
		}

		public class OnLoginDay : IEvent
		{
			public int dayCount;

			public int loginStreak;

			public bool rewardClaimed;
		}

		public class OnNotificationOpened : IEvent
		{
			public int notificationId;

			public string title;
		}

		public class OnButtonTryClicked : IEvent
		{
			public string buttonName;
		}

		public class OnButtonClickSuccess : IEvent
		{
			public string buttonName;
		}

		public class OnTutorialAnalytics : IEvent
		{
			public int status;
		}

		public class AdsRevenueTrackingEvent : IEvent
		{
			public string platform;

			public string source;

			public string platformUnitId;

			public string sourceUnitId;

			public string format;

			public string ad_placement;

			public string estimateValueCurrency;

			public double estimateValue;

			public double estimateValueInUsd;

			public string ui_placement;
		}

		public class AdsImpressionTrackingEvent : IEvent
		{
			public string platform;

			public string source;

			public string platformUnitId;

			public string sourceUnitId;

			public string format;

			public string placement;

			public double revenue;

			public string ui_placement;

			public string isShow;

			public string errorType;

			public string errorCode;
		}

		public class IAPTransactionTrackingEvent : IEvent
		{
			public string productName;

			public string productId;

			public int quantity;

			public double price;

			public string currency;

			public string paymentGateway;

			public string transactionId;

			public string receiptData;
		}

		public class OnAdRequest : IEvent
		{
			public string adType;

			public string ad_placement;

			public string adNetwork;

			public string adUnitId;

			public string isLoad;

			public string errorType;

			public string errorCode;

			public double loadTime;
		}

		public class OnAdClick : IEvent
		{
			public string adType;

			public string ad_placement;

			public string adNetwork;

			public string adUnitId;

			public string uiPlacement;
		}

		public class OnAdComplete : IEvent
		{
			public string adType;

			public string ad_placement;

			public string adNetwork;

			public string adUnitId;

			public string uiPlacement;

			public string endType;

			public double durationAd;
		}

		public class OnAdRewardClaimed : IEvent
		{
			public string adType;

			public string ad_placement;

			public string rewardType;

			public int rewardAmount;

			public string ui_placement;
		}

		public class OnIapClick : IEvent
		{
			public string placement;

			public string packName;

			public string showType;

			public string triggerType;
		}

		public class OnIapPurchaseSuccess : IEvent
		{
			public string placement;

			public string packName;

			public string showType;

			public string triggerType;

			public double price;

			public string currency;

			public string appName;

			public string platform;

			public string appVersion;

			public string userId;

			public int currentLevel;
		}

		public class OnIapPurchaseFailed : IEvent
		{
			public string placement;

			public string packName;

			public string showType;

			public string triggerType;

			public double price;

			public string currency;

			public string failReason;

			public string errorCode;

			public string appName;

			public string platform;

			public string appVersion;

			public string userId;

			public int currentLevel;
		}

		public class OnIapShow : IEvent
		{
			public string placement;

			public string showType;

			public string triggerType;
		}

		public class OnIapClose : IEvent
		{
			public string placement;

			public string showType;

			public string triggerType;

			public double durationIap;
		}

		public class OnRestoreStart : IEvent
		{
		}

		public class OnRestoreResult : IEvent
		{
			public RestoreResult result;

			public int restoredCount;
		}

		public class OnLevelLoaded : IEvent
		{
			public LevelPlayType playType;
		}

		public class OnLevelUnloaded : IEvent
		{
		}

		public class OnLevelDatabaseChanged : IEvent
		{
			public bool isHardMode;
		}

		public class OnLevelFinished : IEvent
		{
			public LevelFinishReason reason;

			public LevelFailReason failReason;
		}

		public class OnLevelLoseCondition : IEvent
		{
			public LevelFailReason failReason;

			public int level_id;
		}

		public class OnPreLost : IEvent
		{
		}

		public class OnPreLostEnd : IEvent
		{
		}

		public class OnLevelJarsReady : IEvent
		{
			public int totalJars;
		}

		public class OnTutorialStart : IEvent
		{
			public TutorialType type;
		}

		public class OnTutorialFinishStep : IEvent
		{
			public TutorialType type;

			public int stepIndex;
		}

		public class OnTutorialComplete : IEvent
		{
			public TutorialType type;
		}

		public class OnSandSwipeCarved : IEvent
		{
		}

		public class OnCellChange : IEvent
		{
			public double newAmount;

			public bool success;
		}

		public class OnCoinChange : IEvent
		{
			public string flowType;

			public ResourceSpendChannel spendReason;

			public int newAmount;

			public ResourceEarnChannel earnReason;

			public int changeAmount;

			public int level_id;

			public bool success;

			public AnalyticsPlacement placement;
		}

		public class OnCoinFlyStarted : IEvent
		{
		}

		public class OnReceiveFinishLevelCoin : IEvent
		{
			public int coinAmount;

			public bool showAnim;
		}

		public class OnGemChange : IEvent
		{
			public string flowType;

			public ResourceSpendChannel spendReason;

			public int newAmount;

			public ResourceEarnChannel earnReason;

			public int changeAmount;

			public int level_id;

			public bool success;

			public AnalyticsPlacement placement;
		}

		public class OnStarChange : IEvent
		{
			public string flowType;

			public ResourceSpendChannel spendReason;

			public int newAmount;

			public ResourceEarnChannel earnReason;

			public int changeAmount;

			public int level_id;

			public bool success;

			public AnalyticsPlacement placement;
		}

		public class OnTrophyItemPurchased : IEvent
		{
			public int itemId;

			public int ownedCount;
		}

		public class OnTrophyRoomCompleted : IEvent
		{
			public int roomId;

			public int nextRoomId;
		}

		public class OnHeartChange : IEvent
		{
			public bool success;

			public string flowType;

			public int changeAmount;

			public int newAmount;

			public int level_id;

			public ResourceEarnChannel reason;

			public AnalyticsPlacement placement;
		}

		public class OnInfiniteHeartChange : IEvent
		{
			public bool isActive;

			public float remainingSeconds;
		}

		public class OnTimedRegenChange : IEvent
		{
			public RegenResourceType type;

			public int newAmount;

			public int changeAmount;

			public RegenChangeSource source;
		}

		public class OnTimedBuffChange : IEvent
		{
			public BuffType type;

			public bool isActive;

			public float remainingSeconds;

			public float magnitude;
		}

		public class OnTimedBuffExpired : IEvent
		{
			public BuffType type;
		}

		public class OnMusicSettingChange : IEvent
		{
			public bool isOn;
		}

		public class OnSfxSettingChange : IEvent
		{
			public bool isOn;
		}

		public class OnHapticSettingChange : IEvent
		{
			public bool isOn;
		}

		public class OnTryBuyBooster : IEvent
		{
			public BoosterType type;
		}

		public class OnBoosterCountChange : IEvent
		{
			public BoosterType type;

			public string flowType;

			public int changeAmount;

			public int newAmount;

			public BoosterEarnReason earnReason;

			public BoosterSpendReason spendReason;

			public bool success;

			public AnalyticsPlacement placement;
		}

		public class OnTryExecuteBooster : IEvent
		{
			public BoosterType type;
		}

		public class OnTryExecuteTutorialBooster : IEvent
		{
			public bool isTutorial;

			public BoosterType type;
		}

		public class OnRevokeBooster : IEvent
		{
			public BoosterType type;
		}

		public class OnExecuteBooster : IEvent
		{
			public BoosterType type;
		}

		public class OnCompleteBoosterExecution : IEvent
		{
		}

		public class OnExecuteBoxSwapBooster : IEvent
		{
			public bool executed;
		}

		public class OnExecuteMagnetBooster : IEvent
		{
			public bool executed;
		}

		public class OnExecuteColorBlastBooster : IEvent
		{
			public bool executed;
		}

		public class OnBoosterUnlocked : IEvent
		{
			public BoosterType type;

			public int quantity;
		}

		public class OnUnlockPopupClosed : IEvent
		{
		}

		public class OnJarFilled : IEvent
		{
		}

		public class OnJarSealed : IEvent
		{
		}

		public class OnIceShapeBroke : IEvent
		{
			public bool shattered;
		}

		public class OnPictureColumnScrolled : IEvent
		{
			public int columnIndex;
		}

		public class OnBeltFlowChanged : IEvent
		{
			public bool active;
		}

		public class OnSandDropChanged : IEvent
		{
			public bool active;
		}

		public class OnSandSwipeStamp : IEvent
		{
		}

		public class OnLevelDatabaseChange : IEvent
		{
			public ALevelDatabase database;
		}

		public class OnLiveEventMilestoneClaimed : IEvent
		{
			public string eventId;

			public int milestoneId;
		}

		public class OnLiveEventCurrencyChanged : IEvent
		{
			public string eventId;

			public int earned;
		}

		public class OnLiveEventPremiumUnlocked : IEvent
		{
			public string eventId;
		}

		public class OnPurchaseNoAds : IEvent
		{
		}

		public class OnAdsClaimed : IEvent
		{
		}

		public class OnShowRewardedFailed : IEvent
		{
		}

		public class OnAdRewardedEvent : IEvent
		{
		}

		public class OnInterstitialAdDisplayed : IEvent
		{
		}

		public class OnInterstitialDisplayFailed : IEvent
		{
		}

		public class OnInterstitialHidden : IEvent
		{
		}

		public class OnApplicationFocusEvent : IEvent
		{
			public bool hasFocus;
		}

		public class OnApplicationPauseEvent : IEvent
		{
			public bool pauseStatus;
		}

		public class OnApplicationQuitEvent : IEvent
		{
		}

		public class OnGameInited : IEvent
		{
		}

		public class OnSceneExit : IEvent
		{
			public SceneIndex sceneToEnter;

			public SceneIndex sceneToExit;
		}

		public class OnStartLoadScene : IEvent
		{
			public SceneIndex sceneToLoad;

			public bool resetProgressBar;
		}

		public class OnBeforeLoadSceneActionInvoked : IEvent
		{
			public SceneIndex sceneToLoad;
		}

		public class OnAfterLoadSceneActionInvoked : IEvent
		{
			public SceneIndex sceneLoaded;
		}

		public class OnFinishLoadScene : IEvent
		{
			public SceneIndex currentScene;
		}

		public class OnSetupSceneStart : IEvent
		{
			public SceneIndex currentScene;
		}

		public class OnSetupScene : IEvent
		{
			public SceneIndex currentScene;
		}

		public class OnSceneStartPlay : IEvent
		{
			public SceneIndex currentScene;
		}

		public class OnStartTestScene : IEvent
		{
		}

		public class OnUpdate : IEvent
		{
		}

		public class OnFixedUpdate : IEvent
		{
		}

		public class OnLateUpdate : IEvent
		{
		}

		public class OnEverySecondTickRealTime : IEvent
		{
		}

		public class OnEverySecondTickGameTime : IEvent
		{
		}

		public class OnLoadingTime : IEvent
		{
			public string screenName;

			public long durationMs;

			public bool isTimeout;
		}

		public class OnErrorEvent : IEvent
		{
			public string errorCode;

			public string errorMessage;

			public string context;
		}

		public class OnPanelStartOpen : IEvent
		{
			public UIPanelID panelID;

			public UILayer layer;
		}

		public class OnPanelStartClose : IEvent
		{
			public UIPanelID panelID;

			public UILayer layer;
		}

		public class OnProfileChanged : IEvent
		{
		}

		public class OnFlowCheckpoint : IEvent
		{
			public string id;
		}

		public class OnAdminTestUnlocked : IEvent
		{
		}

		public readonly JEventBus<IEvent> EventBus;

		public override void Awake()
		{
		}
	}
}
