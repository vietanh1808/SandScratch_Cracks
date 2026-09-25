using JoyCraftSDK.Game.SaveData;

namespace JoyCraftSDK.Game
{
	public class TimelyResetRegenInstance : ATimedRegenInstance
	{
		private readonly int resetValue;

		private readonly long resetIntervalTicks;

		private long TodayMidnightUtcTicks => 0L;

		public TimelyResetRegenInstance(RegenResourceType type, int maxCount, int resetValue, int resetIntervalDays, SavedRegenPoint savedRegenPoint)
			: base(RegenResourceType.None, 0, 0, null)
		{
		}

		public override void ApplyPendingRegen()
		{
		}

		public override float GetSecondsUntilNext()
		{
			return 0f;
		}
	}
}
