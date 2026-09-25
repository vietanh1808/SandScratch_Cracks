using System;

namespace JoyCraftSDK.RemoteConfig
{
	[Serializable]
	public class WinFlowConfig
	{
		public int monetizeStartLevel;

		public int noAdsIconStartLevel;

		public bool IsNoAdsIconLevelReached(int level)
		{
			return false;
		}

		public bool IsNoAdsShopUnlocked(int level)
		{
			return false;
		}

		public bool IsMonetizeLevel(int level)
		{
			return false;
		}
	}
}
