using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.Game
{
	public class TimedRegenManager : ATimedRegenManager
	{
		private readonly Dictionary<RegenResourceType, ATimedRegenInstance> instances;

		private readonly TimedRegenService timedRegenService;

		private bool isInitialized;

		private SavedRegenData savedRegenData => null;

		private void EnsureInitialized()
		{
		}

		public override void RegisterResource(TimedRegenConfigPoint configPoint)
		{
		}

		private static int NormalizeHardMax(TimedRegenConfigPoint configPoint, int effectiveMaxCount)
		{
			return 0;
		}

		public override int GetCount(RegenResourceType type)
		{
			return 0;
		}

		public override int GetMaxCount(RegenResourceType type)
		{
			return 0;
		}

		public override void SetMaxCount(RegenResourceType type, int newMax)
		{
		}

		public override void Add(RegenResourceType type, int amount)
		{
		}

		public override bool Use(RegenResourceType type, int amount)
		{
			return false;
		}

		public override float GetSecondsUntilNext(RegenResourceType type)
		{
			return 0f;
		}

		public override float GetSecondsUntilFull(RegenResourceType type)
		{
			return 0f;
		}

		public override void ApplyPendingRegen(RegenResourceType type)
		{
		}

		public override void DebugSetState(RegenResourceType type, int count, float secondsUntilNext)
		{
		}

		private ATimedRegenInstance GetInstance(RegenResourceType type)
		{
			return null;
		}
	}
}
