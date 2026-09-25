using System;

namespace JoyCraftSDK.Notification
{
	public interface INotificationPlatform
	{
		string PlatformName { get; }

		bool IsAvailable { get; }

		NotificationPermissionStatus PermissionStatus { get; }

		void Initialize(NotificationChannelData channel);

		void RequestPermission(Action<NotificationPermissionStatus> onComplete);

		void OpenSystemNotificationSettings();

		void Schedule(NotificationRequest request);

		bool TryGetLastOpenedId(out int id);

		void Cancel(int id);

		void CancelAllScheduled();

		void ClearDelivered();
	}
}
