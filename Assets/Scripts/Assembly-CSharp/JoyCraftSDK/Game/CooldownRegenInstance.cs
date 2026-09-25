using JoyCraftSDK.Game.SaveData;

namespace JoyCraftSDK.Game
{
	public class CooldownRegenInstance : ATimedRegenInstance
	{
		private readonly int regenSeconds;

		private readonly ATimedRegenService timedRegenService;

		public CooldownRegenInstance(RegenResourceType type, int maxCount, int hardMaxCount, int regenSeconds, SavedRegenPoint savedRegenPoint, ATimedRegenService timedRegenService)
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

		public override float GetSecondsUntilFull()
		{
			return 0f;
		}

		protected override void OnAfterCountChanged()
		{
		}

		public override void DebugSetState(int newCount, float secondsUntilNext)
		{
		}
	}
}
