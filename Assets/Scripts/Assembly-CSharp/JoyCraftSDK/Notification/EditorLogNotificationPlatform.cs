using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Notification
{
	public class EditorLogNotificationPlatform : JBase, INotificationPlatform
	{
		private readonly List<NotificationRequest> scheduledRequests;

		public string PlatformName => null;

		public bool IsAvailable => false;

		public NotificationPermissionStatus PermissionStatus => NotificationPermissionStatus.Unknown;

		public IReadOnlyList<NotificationRequest> ScheduledRequests => null;

		public int PendingOpenedId { get; set; }

		public void Initialize(NotificationChannelData channel)
		{
		}

		public void RequestPermission(Action<NotificationPermissionStatus> onComplete)
		{
		}

		public void OpenSystemNotificationSettings()
		{
		}

		public void Schedule(NotificationRequest request)
		{
		}

		public bool TryGetLastOpenedId(out int id)
		{
			id = default;
			return false;
		}

		public void Cancel(int id)
		{
		}

		public void CancelAllScheduled()
		{
		}

		public void ClearDelivered()
		{
		}
	}
}
