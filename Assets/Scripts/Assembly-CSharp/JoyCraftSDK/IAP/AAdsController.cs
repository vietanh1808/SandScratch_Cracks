using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.IAP
{
	public abstract class AAdsController : JMonoBehaviour
	{
		public abstract bool IsBannerVisible { get; }

		public abstract float BannerHeightPixels { get; }

		public abstract event Action<bool, float> OnBannerVisibilityChanged;

		public abstract bool WatchAdsForReward(string placement, string rewardType, int rewardAmount, Action onReward);

		public abstract void ShowInter(string placement, Action onClosed = null);

		public abstract void ClaimAds();

		public abstract void RequestBanner(object owner);

		public abstract void ReleaseBanner(object owner);

		public abstract void RefreshBanner();
	}
}
