using System.Collections.Generic;
using Newtonsoft.Json;

namespace JTD.Logic
{
	internal static class JTDQueueCodec
	{
		private sealed class QueueEnvelope
		{
			[JsonProperty("v", Order = 0)]
			public int Version { get; set; }

			[JsonProperty("items", Order = 1)]
			public List<EventContext> Items { get; set; }
		}

		private static readonly JsonSerializerSettings Settings;

		internal static string Encode(IReadOnlyList<EventContext> items, int version)
		{
			return null;
		}

		internal static List<EventContext> Decode(string json, int expectedVersion)
		{
			return null;
		}
	}
}
