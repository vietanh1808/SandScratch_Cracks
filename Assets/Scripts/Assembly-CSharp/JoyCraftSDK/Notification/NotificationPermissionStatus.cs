using System;

namespace JoyCraftSDK.Notification
{
	[Serializable]
	public enum NotificationPermissionStatus
	{
		Unknown = 0,
		NotRequested = 1,
		Granted = 2,
		Denied = 3,
		DeniedPermanently = 4
	}
}
