using System.Collections.Generic;
using System.Text;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public class JAnalyticEvent : JBase
	{
		private const string UserIdKey = "user_id";

		public string EventName { get; }

		public Dictionary<string, object> Parameters { get; }

		public JAnalyticEvent(string eventName, bool includeUserId = true)
		{
		}

		public JAnalyticEvent AddParam(string key, string value)
		{
			return null;
		}

		public JAnalyticEvent AddParam(string key, int value)
		{
			return null;
		}

		public JAnalyticEvent AddParam(string key, long value)
		{
			return null;
		}

		public JAnalyticEvent AddParam(string key, float value)
		{
			return null;
		}

		public JAnalyticEvent AddParam(string key, double value)
		{
			return null;
		}

		public JAnalyticEvent AddParam(string key, bool value)
		{
			return null;
		}

		public JAnalyticEvent AddParams(Dictionary<string, object> parameters)
		{
			return null;
		}

		public bool HasParam(string key)
		{
			return false;
		}

		public T GetParam<T>(string key, T defaultValue = default(T))
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}

		private static void AppendParamLine(StringBuilder sb, string key, object value, int keyWidth)
		{
		}
	}
}
