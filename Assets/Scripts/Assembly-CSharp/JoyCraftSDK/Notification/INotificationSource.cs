using System;
using System.Collections.Generic;

namespace JoyCraftSDK.Notification
{
	public interface INotificationSource
	{
		string SourceName { get; }

		bool IsAvailable { get; }

		void Collect(List<NotificationRequest> buffer, DateTime nowUtc);
	}
}
