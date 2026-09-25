using System;
using System.Collections.Generic;
using System.Text;
using JTD;
using JoyCraftSDK.Game;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Analytics
{
	public class GameAnalytics : AGameAnalytics
	{
		private const int MemRingSize = 8;

		private static int _sandSessTransitions;

		private static readonly long[] _sandMemRing;

		private static int _sandMemHead;

		private static int _sandMemFilled;

		private static readonly StringBuilder _sandCrashSb;

		private string _lastScreenName;

		private float _screenEnterTime;

		private readonly List<UIPanelID> _screensViewed;

		private const int ScreensViewedMaxLen = 100;

		private const string LoadDataSource = "local";

		private const string LoadResourceType = "scene";

		private int _loadIdCounter;

		private string _currentLoadId;

		private string _currentLoadContext;

		private const string AdPlatformMediation = "max";

		private const int FirebasePropertyNameMaxLength = 24;

		private readonly DownloadFailRetryTracker _downloadFailRetryTracker;

		private void OnGameInited(ref AEventManager.OnGameInited eventData)
		{
		}

		private void OnApplicationPauseEvent(ref AEventManager.OnApplicationPauseEvent eventData)
		{
		}

		private void OnApplicationFocusEvent(ref AEventManager.OnApplicationFocusEvent eventData)
		{
		}

		private string GetCountryCode()
		{
			return null;
		}

		private static string TutorialIdOf(TutorialType type)
		{
			return null;
		}

		private void OnTutorialStart(ref AEventManager.OnTutorialStart eventData)
		{
		}

		private void OnTutorialFinishStep(ref AEventManager.OnTutorialFinishStep eventData)
		{
		}

		private void OnTutorialComplete(ref AEventManager.OnTutorialComplete eventData)
		{
		}

		private void OnTutorialAnalytics(ref AEventManager.OnTutorialAnalytics eventData)
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnLevelLoadFailed(ref OnLevelLoadFailed eventData)
		{
		}

		private void RecordSandSessionHealth()
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		public void EmitLevelEnd(FinishedLevelSnapshot snap)
		{
		}

		private void OnFeatureUnlocked(ref AEventManager.OnFeatureUnlocked eventData)
		{
		}

		private static string BoosterIdOf(BoosterType type)
		{
			return null;
		}

		private void OnTryExecuteBooster(ref AEventManager.OnTryExecuteBooster eventData)
		{
		}

		private void OnPowerUpBought(ref AEventManager.OnPowerUpBought eventData)
		{
		}

		private void OnExecuteBooster(ref AEventManager.OnExecuteBooster eventData)
		{
		}

		private void OnOutGame(ref AEventManager.OnOutGame eventData)
		{
		}

		private void RaiseResourceEvent(string flowType, AnalyticsResource resource, string reason, int changeAmount, int balance, int levelId, string placement)
		{
		}

		private void RaiseMergeResourceEvent(string flowType, string resourceType, string resourceName, string reason, int changeAmount, int balance, string placement)
		{
		}

		private void OnCoinChange(ref AEventManager.OnCoinChange eventData)
		{
		}

		private void OnGemChange(ref AEventManager.OnGemChange eventData)
		{
		}

		private void OnStarChange(ref AEventManager.OnStarChange eventData)
		{
		}

		private void OnHeartChange(ref AEventManager.OnHeartChange eventData)
		{
		}

		private void EmitBoosterResourceEvent(AEventManager.OnBoosterCountChange eventData)
		{
		}

		private string BuildScreensViewedCsv()
		{
			return null;
		}

		private double GetPrevScreenDuration(float now)
		{
			return 0.0;
		}

		private void MarkScreenShown(string screenName, float now)
		{
		}

		private void OnScreenView(ref AEventManager.OnScreenView eventData)
		{
		}

		private void OnPanelStartOpen(ref AEventManager.OnPanelStartOpen eventData)
		{
		}

		private void OnPanelStartClose(ref AEventManager.OnPanelStartClose eventData)
		{
		}

		private void OnButtonTryClicked(ref AEventManager.OnButtonTryClicked eventData)
		{
		}

		private void OnButtonClickSuccess(ref AEventManager.OnButtonClickSuccess eventData)
		{
		}

		private void OnMusicSettingChange(ref AEventManager.OnMusicSettingChange eventData)
		{
		}

		private void OnSfxSettingChange(ref AEventManager.OnSfxSettingChange eventData)
		{
		}

		private void OnHapticSettingChange(ref AEventManager.OnHapticSettingChange eventData)
		{
		}

		private void OnLoginDay(ref AEventManager.OnLoginDay eventData)
		{
		}

		private void OnNotificationOpened(ref AEventManager.OnNotificationOpened eventData)
		{
		}

		private void OnStartLoadScene(ref AEventManager.OnStartLoadScene eventData)
		{
		}

		private void OnLoadingTime(ref AEventManager.OnLoadingTime eventData)
		{
		}

		private void OnErrorEvent(ref AEventManager.OnErrorEvent eventData)
		{
		}

		private static string AdFormatOf(string adType)
		{
			return null;
		}

		private static string AdNetworkOf(string network)
		{
			return null;
		}

		private void OnAdRequest(ref AEventManager.OnAdRequest eventData)
		{
		}

		private void AdsImpressionTrackingEvent(ref AEventManager.AdsImpressionTrackingEvent eventData)
		{
		}

		private void OnAdClick(ref AEventManager.OnAdClick eventData)
		{
		}

		private void OnAdComplete(ref AEventManager.OnAdComplete eventData)
		{
		}

		private void OnAdRewardClaimed(ref AEventManager.OnAdRewardClaimed eventData)
		{
		}

		private void AdsRevenueTrackingEvent(ref AEventManager.AdsRevenueTrackingEvent eventData)
		{
		}

		private void IAPTransactionTrackingEvent(ref AEventManager.IAPTransactionTrackingEvent eventData)
		{
		}

		private void HandleIapVerifyResult(JTDIapVerifyResult result)
		{
		}

		private void OnIapShow(ref AEventManager.OnIapShow eventData)
		{
		}

		private void OnIapClose(ref AEventManager.OnIapClose eventData)
		{
		}

		private void OnIapClick(ref AEventManager.OnIapClick eventData)
		{
		}

		private void OnIapPurchaseSuccess(ref AEventManager.OnIapPurchaseSuccess eventData)
		{
		}

		private void OnIapPurchaseFailed(ref AEventManager.OnIapPurchaseFailed eventData)
		{
		}

		private void OnRestoreStart(ref AEventManager.OnRestoreStart eventData)
		{
		}

		private void OnRestoreResult(ref AEventManager.OnRestoreResult eventData)
		{
		}

		private void PushBootUserProperties()
		{
		}

		private string GetCurrentModesCsv()
		{
			return null;
		}

		private string GetFirebaseExperimentsCsv()
		{
			return null;
		}

		private void PushStreakUserProperties()
		{
		}

		private static string BoosterResourceName(BoosterType type)
		{
			return null;
		}

		private string GetBoosterBalanceKey(BoosterType type)
		{
			return null;
		}

		private void PushBoosterBalanceUserProperty(BoosterType type)
		{
		}

		private void PushBoosterBalanceUserProperties()
		{
		}

		public override void PushIapUserProperties()
		{
		}

		private void UpdateActiveDay()
		{
		}

		private int ComputeLoginStreak(string prevDate, DateTime today, int currentStreak)
		{
			return 0;
		}

		private string MapConnectionType(NetworkReachability reachability)
		{
			return null;
		}

		private void OnConnectionStatusChanged()
		{
		}

		private void OnBoosterCountChange(ref AEventManager.OnBoosterCountChange eventData)
		{
		}

		public override void Initialize(AAnalyticsManager analyticsManager)
		{
		}

		protected void LogEvent(JAnalyticEvent analyticsEvent)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
