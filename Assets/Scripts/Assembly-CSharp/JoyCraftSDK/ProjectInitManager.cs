using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.RateApp;
using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using JoyCraftSDK.WinStreak;
using UnityEngine;

namespace JoyCraftSDK
{
	public class ProjectInitManager : AProjectInitManager
	{
		private const string Group_Config = "Config";

		private const string Group_Debug = "Debug — Init Flags";

		private const float LoadingTestTime = 0.5f;

		[SerializeField]
		private bool LoadTestScene;

		[SerializeField]
		private bool _internetManagerInited;

		[SerializeField]
		private bool _backendManagerInited;

		[SerializeField]
		private bool _gameDataManagerInited;

		[SerializeField]
		private bool _addressableManagerInited;

		[SerializeField]
		private bool _inputManagerInited;

		[SerializeField]
		private bool _frameRateInited;

		[SerializeField]
		private bool _factoryInited;

		[SerializeField]
		private bool _pushNotiInited;

		[SerializeField]
		private bool _gameServicesInited;

		[SerializeField]
		private bool _consentTrackingInited;

		[SerializeField]
		private bool _blockEffectManagerInited;

		[SerializeField]
		private bool _iosTrackingInited;

		private ARateAppManager _rateAppManager => null;

		private ABattlePassManager _battlePassManager => null;

		private AWinStreakManager _winStreakManager => null;

		private ATrophyRoomManager _trophyRoomManager => null;

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitGame()
		{
		}

		private void OnEverythingInited()
		{
		}

		private bool IsEverythingInited()
		{
			return false;
		}

		private bool IsDeviceInit()
		{
			return false;
		}

		private void LoadGameplay()
		{
		}

		private SceneIndex DecideWhichGameplaySceneToLoad()
		{
			return SceneIndex.Logo;
		}

		private void InitTest()
		{
		}
	}
}
