using System;
using System.Collections.Generic;

namespace JoyCraftSDK.Analytics
{
	public class AnalyticsManager : AAnalyticsManager
	{
		private readonly List<IAnalyticsPlatform> _platforms;

		private IAnalyticsPlatform _primaryPlatform;

		public override void Init(Action onComplete = null)
		{
		}

		public void RegisterPlatform(IAnalyticsPlatform platform, bool isPrimary = false)
		{
		}

		public override void LogEvent(JAnalyticEvent analyticsEvent)
		{
		}

		public override void SetUserProperty(string key, string value)
		{
		}

		public override void SetUserId(string userId)
		{
		}
	}
}
