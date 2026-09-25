using System;
using JoyCraftSDK.Analytics;

namespace JTD
{
	public abstract class AAnalyticsPlatform : IAnalyticsPlatform
	{
		private static bool _warnedUnsupported;

		private bool _warnedUserProperty;

		public abstract string PlatformName { get; }

		public bool IsInitialized { get; protected set; }

		protected static bool IsSendPlatform => false;

		public abstract void Initialize(Action onComplete = null);

		public abstract void SetUserId(string userId);

		public void LogEvent(JAnalyticEvent analyticsEvent)
		{
		}

		protected abstract void OnLogEvent(JAnalyticEvent analyticsEvent);

		public virtual void SetUserProperty(string key, string value)
		{
		}

		public virtual void SetOptOut(bool optedOut)
		{
		}
	}
}
