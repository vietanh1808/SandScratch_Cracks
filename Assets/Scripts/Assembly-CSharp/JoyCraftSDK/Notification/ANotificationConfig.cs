using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Notification
{
	public abstract class ANotificationConfig : JScriptableObject
	{
		public abstract NotificationChannelData Channel { get; }

		public abstract bool TryFillContent(NotificationRequest request);

		public abstract bool TryGetDelaySeconds(int id, out float delaySeconds);

		public abstract bool TryGetTitle(int id, out string title);
	}
}
