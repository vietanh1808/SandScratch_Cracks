namespace JoyCraftSDK.Game
{
	public class TimedRegenService : ATimedRegenService
	{
		public override int CalculatePendingRegen(long lastRegenUtcTicks, int currentCount, int maxCount, int regenSeconds, long nowUtcTicks)
		{
			return 0;
		}

		public override long AdvanceLastRegenTicks(long lastRegenUtcTicks, int regenSeconds, int regenedCount)
		{
			return 0L;
		}

		public override float GetSecondsUntilNext(long lastRegenUtcTicks, int currentCount, int maxCount, int regenSeconds, long nowUtcTicks)
		{
			return 0f;
		}

		public override float GetSecondsUntilFull(long lastRegenUtcTicks, int currentCount, int maxCount, int regenSeconds, long nowUtcTicks)
		{
			return 0f;
		}
	}
}
