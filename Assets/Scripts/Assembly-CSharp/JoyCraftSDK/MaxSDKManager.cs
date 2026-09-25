namespace JoyCraftSDK
{
	public class MaxSDKManager : AAdNetworksManager
	{
		private float _rewardedLoadStartTime;

		private float _interstitialLoadStartTime;

		private float _rewardedDisplayTime;

		private float _interstitialDisplayTime;

		private bool _rewardedRewardReceived;

		private string _lastRewardedPlacement;

		private string _lastInterstitialPlacement;

		private string _lastRewardType;

		private int _lastRewardAmount;

		private bool _bannerReady;

		private string _rewardedAdUnitId => null;

		private string _interstitialAdUnitId => null;

		private string _bannerAdUnitId => null;

		public override bool IsBannerReady => false;

		public override void Init()
		{
		}

		private void OnSdkInitialized(MaxSdkBase.SdkConfiguration sdkConfiguration)
		{
		}

		private void SubscribeRewardedEvents()
		{
		}

		public override void LoadRewarded()
		{
		}

		public override bool IsRewardedAvailable()
		{
			return false;
		}

		public override void ShowRewarded(string placement, string rewardType, int rewardAmount)
		{
		}

		private void OnRewardedAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdLoadFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnRewardedAdDisplayed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdHidden(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdDisplayFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdReceivedReward(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void SubscribeInterstitialEvents()
		{
		}

		public override void LoadInterstitial()
		{
		}

		public override bool IsInterstitialAvailable()
		{
			return false;
		}

		public override void ShowInterstitial(string placement)
		{
		}

		private void OnInterstitialAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdLoadFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnInterstitialAdDisplayed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdHidden(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdDisplayFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void SubscribeBannerEvents()
		{
		}

		public void LoadBanner()
		{
		}

		public override float GetBannerHeightPixels()
		{
			return 0f;
		}

		public void LogBannerMetrics()
		{
		}

		public override void ShowBanner()
		{
		}

		public override void HideBanner()
		{
		}

		public override void DestroyBanner()
		{
		}

		private void OnBannerAdLoaded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdLoadFailed(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnBannerAdClicked(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdExpanded(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdCollapsed(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private static string MapErrorType(MaxSdkBase.ErrorCode code)
		{
			return null;
		}
	}
}
