using System.Collections.Generic;
using Newtonsoft.Json;

namespace JTD.Logic
{
	internal sealed class EventContext
	{
		[JsonProperty("id", Order = 0)]
		public string EventId { get; set; }

		[JsonProperty("ts", Order = 1)]
		public long ClientTsMs { get; set; }

		[JsonProperty("uid", Order = 2)]
		public string UserId { get; set; }

		[JsonProperty("sid", Order = 3)]
		public string SessionId { get; set; }

		[JsonProperty("snum", Order = 4)]
		public uint SessionNumber { get; set; }

		[JsonProperty("en", Order = 5)]
		public string EventName { get; set; }

		[JsonProperty("dsi", Order = 6)]
		public ushort DaySinceInstall { get; set; }

		[JsonProperty("plat", Order = 7)]
		public string Platform { get; set; }

		[JsonProperty("dm", Order = 8)]
		public string DeviceModel { get; set; }

		[JsonProperty("osv", Order = 9)]
		public string OsVersion { get; set; }

		[JsonProperty("did", Order = 10)]
		public string DeviceId { get; set; }

		[JsonProperty("av", Order = 11)]
		public string AppVersion { get; set; }

		[JsonProperty("props", Order = 12)]
		public Dictionary<string, object> Properties { get; set; }

		[JsonProperty("rc", Order = 13)]
		public int RetryCount { get; set; }

		[JsonProperty("eat", Order = 14)]
		public long EnqueuedAtMs { get; set; }
	}
}
