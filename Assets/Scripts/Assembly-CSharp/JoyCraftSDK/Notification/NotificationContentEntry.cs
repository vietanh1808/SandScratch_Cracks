using System;
using UnityEngine;

namespace JoyCraftSDK.Notification
{
	[Serializable]
	public class NotificationContentEntry
	{
		[Tooltip("Khớp với id mà INotificationSource điền vào request.")]
		[SerializeField]
		private int id;

		[Tooltip("Tiêu đề notification.")]
		[SerializeField]
		private string title;

		[Tooltip("Nội dung notification.")]
		[TextArea(2, 4)]
		[SerializeField]
		private string body;

		[Tooltip("Tên icon nhỏ đã khai ở Project Settings > Mobile Notifications. Trống = dùng icon app (Unity sẽ warn ở logcat).")]
		[SerializeField]
		private string smallIcon;

		[Tooltip("Bao nhiêu PHÚT sau khi user rời game thì bắn (1440 = 1 ngày). Chỉ dùng cho loại noti có mốc CỐ ĐỊNH; loại tính runtime (tim đầy) để 0.")]
		[SerializeField]
		private float delayMinutes;

		public int Id => 0;

		public string Title => null;

		public string Body => null;

		public string SmallIcon => null;

		public float DelayMinutes => 0f;
	}
}
