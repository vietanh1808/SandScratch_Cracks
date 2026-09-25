using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public sealed class DatabucketsAnalyticsPlatform : JBase, IAnalyticsPlatform
	{
		private readonly DatabucketsSettings _settings;

		public string PlatformName => null;

		public bool IsInitialized { get; private set; }

		public DatabucketsAnalyticsPlatform(DatabucketsSettings settings)
		{
		}

		public void Initialize(Action onComplete = null)
		{
		}

		public void LogEvent(JAnalyticEvent analyticsEvent)
		{
		}

		public void SetUserProperty(string key, string value)
		{
		}

		public void SetUserId(string userId)
		{
		}
	}
}
