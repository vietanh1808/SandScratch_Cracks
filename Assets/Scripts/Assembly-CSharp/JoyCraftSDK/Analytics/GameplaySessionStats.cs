using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public class GameplaySessionStats : AGameplaySessionStats
	{
		private const string SESSION_GROUP = "SESSION";

		private const string LEVEL_GROUP = "LEVEL";

		private FinishedLevelSnapshot _lastFinished;

		private LevelPlayType _currentPlayType;

		private string _currentVariantId;

		private LevelFinishReason _lastFinishReason;

		private int _itemsTotal;

		private int _itemsCleared;

		public override SessionData SessionData { get; protected set; }

		public override LevelStatsData LevelStatsData { get; protected set; }

		public override string GameMode => null;

		public override LevelPlayType CurrentPlayType => LevelPlayType.Home;

		public override string CurrentVariantId => null;

		public override int Attempts => 0;

		public override int LoseIndex => 0;

		public override int ExitIndex => 0;

		public override float DurationTotal => 0f;

		public override string SessionId => null;

		public override FinishedLevelSnapshot LastFinished => default;

		public override bool IsLastFinishCompleted => false;

		public override bool IsLevelInProgress => false;

		public override int ItemsTotal => 0;

		public override int ItemsCleared => 0;

		public override int GetLoopBy(int levelId)
		{
			return 0;
		}

		public override void FreezeSnapshot(LevelFinishReason reason, LevelFailReason failReason)
		{
		}

		private void ResetLevelData()
		{
		}

		private string GenSessionId()
		{
			return null;
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnExecuteBooster(ref AEventManager.OnExecuteBooster eventData)
		{
		}

		private void OnLevelJarsReady(ref AEventManager.OnLevelJarsReady eventData)
		{
		}

		private void OnJarSealed(ref AEventManager.OnJarSealed eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
