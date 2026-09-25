namespace JTD
{
	public interface IDeviceInfoProvider
	{
		string Platform { get; }

		string DeviceModel { get; }

		string OsVersion { get; }

		string DeviceId { get; }

		string AppVersion { get; }
	}
}
