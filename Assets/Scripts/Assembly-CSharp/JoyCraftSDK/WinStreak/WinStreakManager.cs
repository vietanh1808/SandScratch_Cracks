using JoyCraftSDK.Game;

namespace JoyCraftSDK.WinStreak
{
	public class WinStreakManager : AWinStreakManager
	{
		private bool _subscribed;

		private AWinStreakConfig winStreakConfig => null;

		private ABoosterManager boosterManager => null;

		public override void Initialize()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}
	}
}
