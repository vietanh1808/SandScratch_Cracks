namespace JoyCraftSDK.Game
{
	public class TimedBuffService : ATimedBuffService
	{
		public override bool IsExpired(long startUtcTicks, long durationTicks, long nowUtcTicks)
		{
			return false;
		}

		public override float GetRemainingSeconds(long startUtcTicks, long durationTicks, long nowUtcTicks)
		{
			return 0f;
		}
	}
}
