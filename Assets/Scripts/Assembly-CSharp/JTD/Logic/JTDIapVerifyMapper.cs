using System.Collections.Generic;

namespace JTD.Logic
{
	internal static class JTDIapVerifyMapper
	{
		internal const string NoVerdictStatus = "no_verdict";

		internal static JTDIapVerdict? Decide(bool sendOk, bool parsedOk, JTDWireMapper.IngestAck ack)
		{
			return null;
		}

		internal static string ExtractTransactionId(IReadOnlyDictionary<string, object> properties)
		{
			return null;
		}
	}
}
