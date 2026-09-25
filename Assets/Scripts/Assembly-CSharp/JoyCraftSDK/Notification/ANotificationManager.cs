using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Notification
{
	public abstract class ANotificationManager : JBase
	{
		public abstract bool IsEnabled { get; }

		public abstract bool HasRequestedPermission { get; }

		public abstract NotificationPermissionStatus PermissionStatus { get; }

		public abstract void Init(Action onComplete = null);

		public abstract void Initialize();

		public abstract void RegisterPlatform(INotificationPlatform platform);

		public abstract void RegisterSource(INotificationSource source);

		public abstract void RescheduleAll();

		public abstract void CancelAll();

		public abstract void RequestPermission(Action<NotificationPermissionStatus> onComplete = null);

		public abstract void OpenSystemNotificationSettings();

		public abstract void SetEnabled(bool enabled);
	}
}
