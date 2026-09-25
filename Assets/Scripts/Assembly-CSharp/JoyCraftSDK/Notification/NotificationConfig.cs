using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Notification
{
	[CreateAssetMenu(fileName = "NotificationConfig", menuName = "GameSDK/NotificationConfig")]
	public class NotificationConfig : ANotificationConfig
	{
		[Tooltip("Channel Android dùng chung cho mọi notification của game.")]
		[SerializeField]
		private NotificationChannelData notificationChannel;

		[Tooltip("Nội dung theo từng id. Thiếu id nào thì noti của id đó KHÔNG được bắn.")]
		[SerializeField]
		private List<NotificationContentEntry> contentEntries;

		public override NotificationChannelData Channel => null;

		public override bool TryFillContent(NotificationRequest request)
		{
			return false;
		}

		public override bool TryGetDelaySeconds(int id, out float delaySeconds)
		{
			delaySeconds = default;
			return false;
		}

		public override bool TryGetTitle(int id, out string title)
		{
			title = null;
			return false;
		}

		private NotificationContentEntry FindEntry(int id)
		{
			return null;
		}
	}
}
