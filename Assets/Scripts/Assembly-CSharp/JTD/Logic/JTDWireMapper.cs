using System.Collections.Generic;

namespace JTD.Logic
{
	internal static class JTDWireMapper
	{
		internal struct IngestIapAck
		{
			public string status;

			public string subreason;

			public string purchase_type;
		}

		internal struct IngestAck
		{
			public int accepted;

			public int rejected;

			public IngestIapAck? iap;
		}

		internal const string ReservedUserIdKey = "user_id";

		internal static Dictionary<string, object> BuildEnvelope(EventContext ctx, string sdkVersion = "1.2.0")
		{
			return null;
		}

		private static Dictionary<string, object> StripReserved(Dictionary<string, object> src)
		{
			return null;
		}

		internal static string SerializeBatch(IReadOnlyList<EventContext> batch, string sdkVersion = "1.2.0")
		{
			return null;
		}

		internal static string SerializeSingle(EventContext ctx, string sdkVersion = "1.2.0")
		{
			return null;
		}

		internal static bool TryParseAck(string body, out IngestAck ack)
		{
			ack = default;
			return false;
		}
	}
}
