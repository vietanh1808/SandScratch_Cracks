using UnityEngine;

namespace JTD
{
	public sealed class UnityDeviceInfoProvider : IDeviceInfoProvider
	{
		public string Platform { get; }

		public string DeviceModel { get; }

		public string OsVersion { get; }

		public string DeviceId { get; }

		public string AppVersion { get; }

		private static string MapPlatform(RuntimePlatform p)
		{
			return null;
		}

		private static string HashSHA256(string raw)
		{
			return null;
		}
	}
}
