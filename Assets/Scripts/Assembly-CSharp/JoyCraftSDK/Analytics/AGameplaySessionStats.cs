using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public abstract class AGameplaySessionStats : JMonoBehaviour
	{
		public abstract SessionData SessionData { get; protected set; }

		public abstract LevelStatsData LevelStatsData { get; protected set; }

		public abstract string GameMode { get; }

		public abstract LevelPlayType CurrentPlayType { get; }

		public abstract string CurrentVariantId { get; }

		public abstract int Attempts { get; }

		public abstract int LoseIndex { get; }

		public abstract int ExitIndex { get; }

		public abstract float DurationTotal { get; }

		public abstract string SessionId { get; }

		public abstract FinishedLevelSnapshot LastFinished { get; }

		public abstract bool IsLastFinishCompleted { get; }

		public abstract bool IsLevelInProgress { get; }

		public abstract int ItemsTotal { get; }

		public abstract int ItemsCleared { get; }

		public abstract int GetLoopBy(int levelId);

		public abstract void FreezeSnapshot(LevelFinishReason reason, LevelFailReason failReason);

		protected virtual void OnLevelStatsReset()
		{
		}
	}
}
