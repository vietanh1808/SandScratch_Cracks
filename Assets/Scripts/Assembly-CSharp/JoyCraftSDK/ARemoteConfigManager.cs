using System;
using System.Collections.Generic;
using JoyCraftSDK.RemoteConfig;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ARemoteConfigManager : JBase
	{
		private bool _bannerAdsEnabled;

		private readonly Dictionary<string, string> _debugOverrides;

		public List<EconomyData> EconomyData { get; protected set; }

		public WinFlowConfig WinFlow { get; protected set; }

		public LiveEventRemoteConfig LiveEventRemote { get; protected set; }

		public bool BannerAdsEnabled
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public string GameVersion { get; protected set; }

		public abstract string LevelVariantOverridesJson { get; }

		public abstract void Init(Action onComplete = null);

		public void SetDebugOverride(string key, string rawValue)
		{
		}

		public void ClearDebugOverride(string key)
		{
		}

		protected bool TryGetDebugOverride(string key, out string rawValue)
		{
			rawValue = null;
			return false;
		}

		public bool IsForceUpdateRequired()
		{
			return false;
		}
	}
}
