using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JoyCraftSDK.IAP
{
	public class AdsController : AAdsController
	{
		[CompilerGenerated]
		private new Action<bool, float> m_OnBannerVisibilityChanged;

		private bool _isShowingRewardedAd;

		private Action _successRewardedAdCallback;

		private bool _isShowingInterstitialAd;

		private Action _interstitialClosedCallback;

		private readonly HashSet<object> _bannerRequesters;

		private bool _bannerVisible;

		private float _bannerHeightPixels;

		public override bool IsBannerVisible => false;

		public override float BannerHeightPixels => 0f;

		public override event Action<bool, float> OnBannerVisibilityChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override bool WatchAdsForReward(string placement, string rewardType, int rewardAmount, Action onReward)
		{
			return false;
		}

		public override void ShowInter(string placement, Action onClosed = null)
		{
		}

		public override void ClaimAds()
		{
		}

		public override void RequestBanner(object owner)
		{
		}

		public override void ReleaseBanner(object owner)
		{
		}

		public override void RefreshBanner()
		{
		}

		private void UpdateBannerState(bool visible)
		{
		}

		private void StartShowRewardedAd(string placement, string rewardType, int rewardAmount)
		{
		}

		private void StartShowInterstitialAd(string placement)
		{
		}

		private void OnRewardedAdCompleted(ref AEventManager.OnAdRewardedEvent eventdata)
		{
		}

		private void OnRewardedAdFailed(ref AEventManager.OnShowRewardedFailed eventdata)
		{
		}

		private void OnInterstitialAdHidden(ref AEventManager.OnInterstitialHidden eventdata)
		{
		}

		private void CleanupRewardedAd()
		{
		}

		private void CleanupInterstitialAd()
		{
		}

		private void SubscribeToRewardedAdEvents()
		{
		}

		private void UnsubscribeFromRewardedAdEvents()
		{
		}

		private void SubscribeToInterstitialAdEvents()
		{
		}

		private void UnsubscribeFromInterstitialAdEvents()
		{
		}

		private void LoadAllAds(ref AEventManager.OnGameInited eventdata)
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
