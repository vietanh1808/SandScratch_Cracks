using System.Collections.Generic;

namespace JTD.Logic
{
	internal static class JTDEventEnricher
	{
		internal static Dictionary<string, object> Enrich(string eventName, Dictionary<string, object> props, string installDate, bool isFirstSession, int sessionDurationSec)
		{
			return null;
		}

		private static Dictionary<string, object> Copy(Dictionary<string, object> src)
		{
			return null;
		}

		private static bool TryCoerceInt(object value, out int result)
		{
			result = default;
			return false;
		}
	}
}
