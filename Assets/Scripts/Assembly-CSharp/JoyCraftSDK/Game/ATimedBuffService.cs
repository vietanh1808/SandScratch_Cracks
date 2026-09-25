using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedBuffService : JBase
	{
		public abstract bool IsExpired(long startUtcTicks, long durationTicks, long nowUtcTicks);

		public abstract float GetRemainingSeconds(long startUtcTicks, long durationTicks, long nowUtcTicks);
	}
}
