using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.Game
{
	public class TimedBuffManager : ATimedBuffManager
	{
		private readonly Dictionary<BuffType, ATimedBuffInstance> activeBuffs;

		private readonly TimedBuffService timedBuffService;

		private bool isLoaded;

		private SavedBuffData savedBuffData => null;

		private void EnsureLoaded()
		{
		}

		public override void RecalculateActiveBuffs()
		{
		}

		public override void Activate(BuffType type, float durationSeconds)
		{
		}

		public override void Deactivate(BuffType type)
		{
		}

		public override bool IsActive(BuffType type)
		{
			return false;
		}

		public override float GetRemainingSeconds(BuffType type)
		{
			return 0f;
		}

		public override float GetMagnitude(BuffType type)
		{
			return 0f;
		}

		public override IReadOnlyCollection<BuffType> GetActiveBuffs()
		{
			return null;
		}

		private ATimedBuffInstance GetLiveInstance(BuffType type)
		{
			return null;
		}

		private ATimedBuffInstance GetOrCreateInstance(BuffType type)
		{
			return null;
		}

		private void ExpireAndUnregister(BuffType type)
		{
		}

		private float GetConfigMagnitude(BuffType type)
		{
			return 0f;
		}
	}
}
