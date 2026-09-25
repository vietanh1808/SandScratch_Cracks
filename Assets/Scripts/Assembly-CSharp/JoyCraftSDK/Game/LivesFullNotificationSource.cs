using System;
using System.Collections.Generic;
using JoyCraftSDK.Notification;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class LivesFullNotificationSource : JBase, INotificationSource
	{
		public string SourceName => null;

		public bool IsAvailable => false;

		public void Collect(List<NotificationRequest> buffer, DateTime nowUtc)
		{
		}
	}
}
