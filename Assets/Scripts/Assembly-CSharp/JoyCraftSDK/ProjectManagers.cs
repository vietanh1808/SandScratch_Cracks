using JoyCraftSDK.AdminTest;
using JoyCraftSDK.Analytics;
using JoyCraftSDK.DailyReward;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Gameplay;
using JoyCraftSDK.IAP;
using JoyCraftSDK.JInput;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Notification;
using JoyCraftSDK.RateApp;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.SaveSystem.SaveDataBuilders;
using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using JoyCraftSDK.WinStreak;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

namespace JoyCraftSDK
{
	public class ProjectManagers : MonoBehaviour
	{
		[SerializeField]
		public AGameConfig GameConfig;

		public Camera MainCamera;

		private ABackgroundCamera _backgroundCamera;

		private ABackgroundUIManager _backgroundUIManager;

		public static ProjectManagers Instance;

		public ALevelSwapController LevelSwapController { get; private set; }

		public AWinStreakManager WinStreakManager { get; private set; }

		public ADailyRewardManager DailyRewardManager { get; private set; }

		public ATrophyRoomManager TrophyRoomManager { get; private set; }

		public ALogger Logger { get; private set; }

		public AProjectInitManager ProjectInitManager { get; private set; }

		public AEventManager EventManager { get; private set; }

		public AFactory Factory { get; private set; }

		public AScenesManager ScenesManager { get; private set; }

		public APoolManager PoolManager { get; private set; }

		public ATaskManager TaskManager { get; private set; }

		public AFrameRateManager ProjectFrameRateManager { get; private set; }

		public AInternetManager ProjectInternetManager { get; private set; }

		public AGlobalVarsManager GlobalVarsManager { get; private set; }

		public AAudioManager AudioManager { get; private set; }

		public AHapticManager HapticManager { get; private set; }

		public ALoadSceneManager LoadSceneManager { get; private set; }

		public ASaveReferencesManager SaveReferencesManager { get; private set; }

		public ASavedDataBuilder SavedDataBuilder { get; private set; }

		public AGameDataManager GameDataManager { get; private set; }

		public AGuiManager GuiManager { get; private set; }

		public APopupMessageController PopupMessageController { get; private set; }

		public AShopContentManager ShopContentManager { get; private set; }

		public AJInputManager JInputManager { get; private set; }

		public AAddressableManager AddressableManager { get; private set; }

		public AAdNetworksManager AdNetworksManager { get; private set; }

		public AAdjustManager AdjustManager { get; private set; }

		public AGameAnalytics GameAnalytics { get; private set; }

		public ABackendManager BackendManager { get; private set; }

		public ARealtimeDatabaseManager RealtimeDatabase { get; private set; }

		public AAuthenticationManager AuthenticationManager { get; private set; }

		public ARemoteConfigManager RemoteConfigManager { get; private set; }

		public AAnalyticsManager AnalyticsManager { get; private set; }

		public AIAPBuyService IAPBuyService { get; private set; }

		public AIAPProvider IAPProvider { get; private set; }

		public ARateAppManager RateAppManager { get; private set; }

		public AForceUpdateController ForceUpdateController { get; private set; }

		public ANotificationManager NotificationManager { get; private set; }

		public AResourceManager ResourceManager { get; private set; }

		public ADevToolsManager DevToolsManager { get; private set; }

		public ACheatManager CheatManager { get; private set; }

		public ATestFactory TestFactory { get; private set; }

		public AAdsController AdsController { get; private set; }

		public ASaveDataReader SaveDataReader { get; private set; }

		public ASaveDataWriter SaveDataWriter { get; private set; }

		public ATimeManager TimeManager { get; private set; }

		public AGameplaySessionStats GameplaySessionStats { get; private set; }

		public ATextController TextController { get; private set; }

		public AFeatureUnlockController FeatureUnlockController { get; private set; }

		public AGameFeatureManager GameFeatureManager { get; private set; }

		public ATutorialController TutorialController { get; private set; }

		public AUnlockDispatcher UnlockDispatcher { get; private set; }

		public AGameplayController GameplayController { get; private set; }

		public ALevelController LevelController { get; private set; }

		public ABoosterManager BoosterManager { get; private set; }

		public AEffectController EffectController { get; private set; }

		public ATimedRegenManager TimedRegenManager { get; private set; }

		public ATimedBuffManager TimedBuffManager { get; private set; }

		public AAnchorRegistry AnchorRegistry { get; private set; }

		public ABattlePassManager BattlePassManager { get; private set; }

		public ARewardFlyService RewardFlyService { get; private set; }

		public AGameSceneManager GameSceneManager { get; private set; }

		public ABackgroundCamera BackgroundCamera => null;

		public ABackgroundUIManager BackgroundUIManager => null;

		public Camera BackgroundCam => null;

		public int ScreenWidth => 0;

		public int ScreenHeight => 0;

		public bool IsGameplaySceneManagerReady { get; private set; }

		protected virtual string LogName => null;

		[Inject]
		public void ConstructGame(ALevelSwapController levelSwap, AWinStreakManager winStreakManager, ADailyRewardManager dailyRewardManager, ATrophyRoomManager trophyRoomManager)
		{
		}

		[Inject]
		public void Construct(ALogger logger, AProjectInitManager projectInitManager, AEventManager eventManager, AFactory factory, AScenesManager scenesManager, APoolManager poolManager, ATaskManager taskManager, AFrameRateManager frameRateManager, AInternetManager internetManager, AGlobalVarsManager globalVarsManager, AAudioManager audioManager, AHapticManager hapticManager, ALoadSceneManager loadSceneManager, ASaveReferencesManager saveReferencesManager, ASavedDataBuilder savedDataBuilder, AGameDataManager gameDataManager, AGuiManager guiManager, APopupMessageController popupMessageController, AShopContentManager shopContentManager, AJInputManager inputManager, AAddressableManager addressableManager, AAdNetworksManager adNetworksManager, AAdjustManager adjustManager, AGameAnalytics gameAnalytics, ABackendManager backendManager, ARealtimeDatabaseManager realtimeDatabaseManager, AAuthenticationManager authenticationManager, ARemoteConfigManager remoteConfigManager, AAnalyticsManager analyticsManager, AIAPBuyService iapBuyService, AIAPProvider iapProvider, ARateAppManager rateAppManager, AForceUpdateController forceUpdateController, ANotificationManager notificationManager, AResourceManager resourceManager, ADevToolsManager devToolsManager, ACheatManager cheatManager, ATestFactory testFactory, AAdsController adsController, ASaveDataReader saveDataReader, ASaveDataWriter saveDataWriter, ATimeManager timeManager, AGameplaySessionStats gameplaySessionStats, ATextController textController, AFeatureUnlockController featureUnlockController, AGameFeatureManager gameFeatureManager, ATutorialController tutorialController, AUnlockDispatcher unlockDispatcher, AGameplayController gameplayController, ALevelController levelController, ABoosterManager boosterManager, AEffectController effectController, ATimedRegenManager timedRegenManager, ATimedBuffManager timedBuffManager, AAnchorRegistry anchorRegistry, ABattlePassManager battlePassManager, ARewardFlyService rewardFlyService)
		{
		}

		public void Awake()
		{
		}

		private void GetCamera(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupSceneScope(ref AEventManager.OnBeforeLoadSceneActionInvoked eventData)
		{
		}

		protected void Log(string message)
		{
		}

		protected void LogWarning(string message)
		{
		}

		protected void LogError(string message)
		{
		}
	}
}
