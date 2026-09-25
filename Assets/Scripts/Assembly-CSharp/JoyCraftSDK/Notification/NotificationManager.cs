using System;
using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.Notification
{
	public class NotificationManager : ANotificationManager
	{
		private const float MinDelaySeconds = 60f;

		private readonly List<INotificationPlatform> platforms;

		private readonly List<INotificationSource> sources;

		private readonly List<NotificationRequest> requestBuffer;

		private bool subscribed;

		private bool channelInited;

		private SavedSettingData savedSettingData => null;

		private ANotificationConfig notificationConfig => null;

		public override bool IsEnabled => false;

		public override bool HasRequestedPermission => false;

		public override NotificationPermissionStatus PermissionStatus => NotificationPermissionStatus.Unknown;

		public override void Init(Action onComplete = null)
		{
		}

		public override void Initialize()
		{
		}

		private void TryRaiseOpenedFromNotification()
		{
		}

		public override void RegisterPlatform(INotificationPlatform platform)
		{
		}

		public override void RegisterSource(INotificationSource source)
		{
		}

		private void EnsureChannelInited()
		{
		}

		private void OnApplicationPause(ref AEventManager.OnApplicationPauseEvent eventData)
		{
		}

		private void OnApplicationQuit(ref AEventManager.OnApplicationQuitEvent eventData)
		{
		}

		public override void RescheduleAll()
		{
		}

		public override void CancelAll()
		{
		}

		public override void RequestPermission(Action<NotificationPermissionStatus> onComplete = null)
		{
		}

		public override void OpenSystemNotificationSettings()
		{
		}

		public override void SetEnabled(bool enabled)
		{
		}

		private string PlatformNames()
		{
			return null;
		}
	}
}
