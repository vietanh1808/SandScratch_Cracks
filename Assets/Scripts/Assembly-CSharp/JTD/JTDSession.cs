namespace JTD
{
	internal sealed class JTDSession
	{
		internal const string KeyUserId = "jtd.anon_user_id";

		internal const string KeyInstall = "jtd.install_epoch_ms";

		internal const string KeySessionNumber = "jtd.session_number";

		internal const long IdleThresholdMs = 1800000L;

		private const long MsPerDay = 86400000L;

		private readonly IDeviceInfoProvider _device;

		private long _lastActiveMs;

		private long _sessionStartMs;

		public string UserId { get; private set; }

		public string SessionId { get; private set; }

		public uint SessionNumber { get; private set; }

		public long InstallEpochMs { get; private set; }

		public string Platform => null;

		public string DeviceModel => null;

		public string OsVersion => null;

		public string DeviceId => null;

		public string AppVersion => null;

		public ushort DaySinceInstall => 0;

		public string InstallDate => null;

		public bool IsFirstSession => false;

		public int SessionDurationSec => 0;

		public JTDSession(IDeviceInfoProvider device)
		{
		}

		public void StartNewSession()
		{
		}

		public void OnResume()
		{
		}

		public void NoteActivity()
		{
		}

		public void SetUserId(string userId)
		{
		}

		private static string LoadOrCreateUserId()
		{
			return null;
		}

		private static long LoadOrCreateInstall()
		{
			return 0L;
		}

		private static uint LoadSessionNumber()
		{
			return 0u;
		}
	}
}
