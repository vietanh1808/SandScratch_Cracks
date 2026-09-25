using System;

namespace JoyCraftSDK.Notification
{
	[Serializable]
	public class NotificationRequest
	{
		public int Id { get; }

		public float DelaySeconds { get; }

		public string Title { get; private set; }

		public string Body { get; private set; }

		public string ChannelId { get; private set; }

		public string SmallIcon { get; private set; }

		public NotificationRequest(int id, float delaySeconds)
		{
		}

		public void SetContent(string title, string body, string channelId, string smallIcon)
		{
		}

		public bool HasContent()
		{
			return false;
		}
	}
}
