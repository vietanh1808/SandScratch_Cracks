using JoyCraftSDK.AdminTest;
using JoyCraftSDK.Analytics;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Gameplay;
using JoyCraftSDK.IAP;
using JoyCraftSDK.JInput;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.SaveSystem.SaveDataBuilders;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;
using VContainer.Unity;

namespace JoyCraftSDK
{
	public class ProjectScope : LifetimeScope
	{
		[SerializeField]
		private ALevelSwapController levelSwap;

		private const string Group_Project = "Project";

		private const string Group_Game = "Game Specifics";

		[SerializeField]
		private ALogger logger;

		[SerializeField]
		private ProjectManagers projectManager;

		[SerializeField]
		private AProjectInitManager projectInitManager;

		[SerializeField]
		private AEventManager eventManager;

		[SerializeField]
		private AFactory factory;

		[SerializeField]
		private AScenesManager scenesManager;

		[SerializeField]
		private APoolManager poolManager;

		[SerializeField]
		private ATaskManager taskManager;

		[SerializeField]
		private AFrameRateManager frameRateManager;

		[SerializeField]
		private AInternetManager internetManager;

		[SerializeField]
		private AGlobalVarsManager globalVarsManager;

		[SerializeField]
		private AAudioManager audioManager;

		[SerializeField]
		private AHapticManager hapticManager;

		[SerializeField]
		private ASaveDatabaseService database;

		[SerializeField]
		private ASaveReferencesManager saveReferencesManager;

		[SerializeField]
		private ASavedDataBuilder savedDataBuilder;

		[SerializeField]
		private AGameDataManager gameDataManager;

		[SerializeField]
		private AGuiManager guiManager;

		[SerializeField]
		private APopupMessageController popupMessageController;

		[SerializeField]
		private AJInputManager inputManager;

		[SerializeField]
		private AAddressableManager _addressableManager;

		[SerializeField]
		private AAdNetworksManager adNetworksManager;

		[SerializeField]
		private AAdjustManager adjustManager;

		[SerializeField]
		private AGameAnalytics gameAnalytics;

		[SerializeField]
		private AResourceManager resourceManager;

		[SerializeField]
		[FormerlySerializedAs("adminTestManager")]
		private ADevToolsManager devToolsManager;

		[SerializeField]
		private ACheatManager cheatManager;

		[SerializeField]
		private AAdsController adsController;

		[SerializeField]
		private ASaveDataReader saveDataReader;

		[SerializeField]
		private ASaveDataWriter saveDataWriter;

		[SerializeField]
		private ATimeManager timeManager;

		[SerializeField]
		private AGameplaySessionStats gameplaySessionStats;

		[SerializeField]
		private AFeatureUnlockController featureUnlockController;

		[SerializeField]
		private AGameFeatureManager gameFeatureManager;

		[SerializeField]
		private ATutorialController tutorialController;

		[SerializeField]
		private AUnlockDispatcher unlockDispatcher;

		[SerializeField]
		private AGameplayController gameplayController;

		[SerializeField]
		private LevelSpawner levelSpawner;

		[SerializeField]
		private ABoosterManager boosterManager;

		[SerializeField]
		private AEffectController effectController;

		protected override void Awake()
		{
		}

		private void AddAutoInjectGameObjects()
		{
		}

		protected override void Configure(IContainerBuilder builder)
		{
		}

		private void ConfigureGame(IContainerBuilder builder)
		{
		}
	}
}
