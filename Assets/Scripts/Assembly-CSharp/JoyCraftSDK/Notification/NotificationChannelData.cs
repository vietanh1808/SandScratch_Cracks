using System;
using UnityEngine;

namespace JoyCraftSDK.Notification
{
	[Serializable]
	public class NotificationChannelData
	{
		[Tooltip("ID kỹ thuật của channel. ĐỔI = Android coi như channel MỚI (channel cũ user đã tắt vẫn nằm lại máy).")]
		[SerializeField]
		private string id;

		[Tooltip("Tên user THẤY trong Settings > Notifications của máy.")]
		[SerializeField]
		private string channelName;

		[Tooltip("Mô tả hiện dưới tên channel trong Settings máy.")]
		[SerializeField]
		private string description;

		public string Id => null;

		public string ChannelName => null;

		public string Description => null;
	}
}
