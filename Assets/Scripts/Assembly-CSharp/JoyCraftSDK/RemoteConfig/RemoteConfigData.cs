using System;
using System.Collections.Generic;

namespace JoyCraftSDK.RemoteConfig
{
	[Serializable]
	public class RemoteConfigData
	{
		public List<EconomyData> economyData;

		public WinFlowConfig winFlow;

		public LiveEventRemoteConfig liveEventRemote;

		public bool bannerAdsEnabled;
	}
}
