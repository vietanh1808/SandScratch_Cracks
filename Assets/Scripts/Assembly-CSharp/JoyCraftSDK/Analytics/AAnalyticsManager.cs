using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public abstract class AAnalyticsManager : JBase
	{
		public abstract void Init(Action onComplete = null);

		public abstract void LogEvent(JAnalyticEvent analyticsEvent);

		public abstract void SetUserProperty(string key, string value);

		public abstract void SetUserId(string userId);
	}
}
