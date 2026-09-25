using System;
using System.Collections.Generic;
using Firebase.Analytics;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public class FirebaseAnalyticsPlatform : JBase, IAnalyticsPlatform
	{
		public string PlatformName => null;

		public bool IsInitialized { get; private set; }

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

		private Parameter[] ConvertToFirebaseParams(Dictionary<string, object> parameters)
		{
			return null;
		}
	}
}
