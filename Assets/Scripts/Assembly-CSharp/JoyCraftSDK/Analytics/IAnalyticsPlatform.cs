using System;

namespace JoyCraftSDK.Analytics
{
	public interface IAnalyticsPlatform
	{
		string PlatformName { get; }

		bool IsInitialized { get; }

		void Initialize(Action onComplete = null);

		void LogEvent(JAnalyticEvent analyticsEvent);

		void SetUserProperty(string key, string value);

		void SetUserId(string userId);
	}
}
