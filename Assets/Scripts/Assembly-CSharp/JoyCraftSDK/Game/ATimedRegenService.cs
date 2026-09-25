using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedRegenService : JBase
	{
		public abstract int CalculatePendingRegen(long lastRegenUtcTicks, int currentCount, int maxCount, int regenSeconds, long nowUtcTicks);

		public abstract long AdvanceLastRegenTicks(long lastRegenUtcTicks, int regenSeconds, int regenedCount);

		public abstract float GetSecondsUntilNext(long lastRegenUtcTicks, int currentCount, int maxCount, int regenSeconds, long nowUtcTicks);

		public abstract float GetSecondsUntilFull(long lastRegenUtcTicks, int currentCount, int maxCount, int regenSeconds, long nowUtcTicks);
	}
}
