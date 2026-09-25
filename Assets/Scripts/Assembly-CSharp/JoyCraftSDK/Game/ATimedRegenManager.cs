using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedRegenManager : JBase
	{
		public abstract void RegisterResource(TimedRegenConfigPoint configPoint);

		public abstract int GetCount(RegenResourceType type);

		public abstract int GetMaxCount(RegenResourceType type);

		public abstract void SetMaxCount(RegenResourceType type, int newMax);

		public abstract void Add(RegenResourceType type, int amount);

		public abstract bool Use(RegenResourceType type, int amount);

		public abstract float GetSecondsUntilNext(RegenResourceType type);

		public abstract float GetSecondsUntilFull(RegenResourceType type);

		public abstract void ApplyPendingRegen(RegenResourceType type);

		public abstract void DebugSetState(RegenResourceType type, int count, float secondsUntilNext);
	}
}
