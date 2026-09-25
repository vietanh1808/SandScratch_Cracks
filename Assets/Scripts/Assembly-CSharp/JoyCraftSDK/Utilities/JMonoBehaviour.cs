using System;
using System.Threading;
using GenericEventBus;
using JoyCraftSDK.AdminTest;
using JoyCraftSDK.Analytics;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Gameplay;
using JoyCraftSDK.IAP;
using JoyCraftSDK.JInput;
using JoyCraftSDK.Notification;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.SaveSystem.SaveDataBuilders;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public class JMonoBehaviour : MonoBehaviour
	{
		private Transform _privateTransform;

		public Relay<JMonoBehaviour> OnDestroyRelay;

		protected ABackendManager _backendManager => null;

		protected AAdjustManager _adjustManager => null;

		protected AAdNetworksManager _adNetworksManager => null;

		protected ARealtimeDatabaseManager _realtimeDatabase => null;

		protected AAuthenticationManager _authenticationManager => null;

		protected ARemoteConfigManager _remoteConfigManager => null;

		protected AAnalyticsManager _analyticsManager => null;

		protected AGameAnalytics _gameAnalytics => null;

		protected AGameplaySessionStats _gameplaySessionStats => null;

		protected AProjectInitManager _projectInitManager => null;

		protected ALogger _logger => null;

		protected APoolManager _poolManager => null;

		protected ATaskManager _taskManager => null;

		protected ALoadSceneManager _loadSceneManager => null;

		protected AInternetManager _internetManager => null;

		protected AFrameRateManager _frameRateManager => null;

		protected ATimeManager _timeManager => null;

		protected AFactory _factory => null;

		protected ADevToolsManager _devToolsManager => null;

		protected ACheatManager _cheatManager => null;

		protected ANotificationManager _notificationManager => null;

		protected AEventManager _eventManager => null;

		protected GenericEventBus<IEvent> _eventBus => null;

		protected AAudioManager _audioManager => null;

		protected AHapticManager _hapticManager => null;

		protected AGameDataManager _gameDataManager => null;

		protected AResourceManager _resourceManager => null;

		protected ASavedDataBuilder _savedDataBuilder => null;

		protected ASaveDataReader _saveDataReader => null;

		protected ASaveDataWriter _saveDataWriter => null;

		protected AAddressableManager _addressableManager => null;

		protected AGuiManager _guiManager => null;

		protected APopupMessageController _popupMessageController => null;

		protected ABackgroundUIManager _backgroundUIManager => null;

		protected ATextController _textController => null;

		protected AShopContentManager _shopContentManager => null;

		protected AAdsController _adsController => null;

		protected AIAPBuyService _iapBuyService => null;

		protected AIAPProvider _iapProvider => null;

		protected ATimedRegenManager _timedRegenManager => null;

		protected ATimedBuffManager _timedBuffManager => null;

		protected ATutorialController _tutorialController => null;

		protected AFeatureUnlockController _featureUnlockController => null;

		protected AGameFeatureManager _gameFeatureManager => null;

		protected ABoosterManager _boosterManager => null;

		protected ALevelController _levelController => null;

		protected ALevelSwapController _levelSwap => null;

		protected AGameplayController _gameplayController => null;

		protected AEffectController _effectController => null;

		protected AAnchorRegistry _anchorRegistry => null;

		protected ARewardFlyService _rewardFlyService => null;

		protected AGameSceneManager _gameSceneManager => null;

		protected AGlobalVarsManager _globalVarsManager => null;

		protected AJInputManager _inputManager => null;

		protected ATestFactory _testFactory => null;

		protected bool _isTesting => false;

		protected AGameConfig _gameConfig => null;

		protected SavedGameData _savedGameData => null;

		protected SavedPlayerProgressData _playerProgressData => null;

		protected string _userID => null;

		protected double _currentCoin => 0.0;

		protected bool isSfxEnabled => false;

		protected bool isMusicEnabled => false;

		protected SerializedDateTime _timeNow => null;

		protected float _deltaTime => 0f;

		protected float _fixedDeltaTime => 0f;

		protected Camera _mainCamera => null;

		protected Camera _backgroundCamera => null;

		protected int _screenWidth => 0;

		protected int _screenHeight => 0;

		public Transform _transform => null;

		public Vector3 _transformPosition => default;

		public int UniqueID { get; private set; }

		protected CancellationToken _cancelOnDestroy => default;

		protected virtual string LogName => null;

		public virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		protected virtual void OnApplicationPause(bool pauseStatus)
		{
		}

		protected virtual void OnApplicationQuit()
		{
		}

		protected virtual void Subscribe()
		{
		}

		protected virtual void Unsubscribe()
		{
		}

		protected void DoAfterSeconds(float seconds, Action action)
		{
		}

		protected void DoAfterRealSeconds(float seconds, Action action)
		{
		}

		protected void DoNextFrame(Action action)
		{
		}

		protected AUIConfig GetGameUIConfig()
		{
			return null;
		}

		protected virtual bool IsLogging()
		{
			return false;
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

		public void SetActive(bool isActive)
		{
		}

		public void SetActive(GameObject target, bool isActive)
		{
		}

		public void SetActiveAfterSeconds(bool isActive, float seconds)
		{
		}
	}
}
