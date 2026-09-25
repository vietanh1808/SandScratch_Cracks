using System;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AAdNetworksManager : JMonoBehaviour
	{
		[CompilerGenerated]
		private Action m_OnBannerReadyChanged;

		public abstract bool IsBannerReady { get; }

		public event Action OnBannerReadyChanged
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

		public abstract void Init();

		public abstract void LoadRewarded();

		public abstract bool IsRewardedAvailable();

		public abstract void ShowRewarded(string placement, string rewardType, int rewardAmount);

		public abstract void LoadInterstitial();

		public abstract bool IsInterstitialAvailable();

		public abstract void ShowInterstitial(string placement);

		public abstract void ShowBanner();

		public abstract void HideBanner();

		public abstract void DestroyBanner();

		public abstract float GetBannerHeightPixels();

		protected void RaiseBannerReadyChanged()
		{
		}
	}
}
