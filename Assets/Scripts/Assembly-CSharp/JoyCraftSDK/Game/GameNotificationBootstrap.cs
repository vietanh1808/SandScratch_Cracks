using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class GameNotificationBootstrap : JBase
	{
		private readonly LivesFullNotificationSource livesFullSource;

		private readonly OfflineReminderNotificationSource offlineReminderSource;

		private readonly NotificationPermissionPrompter permissionPrompter;

		private bool initialized;

		public void Initialize()
		{
		}
	}
}
