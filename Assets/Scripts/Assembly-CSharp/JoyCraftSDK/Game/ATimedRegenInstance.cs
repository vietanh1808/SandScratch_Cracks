using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedRegenInstance : JBase
	{
		private readonly RegenResourceType type;

		private int maxCount;

		private int hardMaxCount;

		private readonly SavedRegenPoint savedRegenPoint;

		public RegenResourceType Type => RegenResourceType.None;

		public int MaxCount => 0;

		public int HardMaxCount => 0;

		protected int count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected long lastRegenUtcTicks
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		protected ATimedRegenInstance(RegenResourceType type, int maxCount, int hardMaxCount, SavedRegenPoint savedRegenPoint)
		{
		}

		public int GetCount()
		{
			return 0;
		}

		public void Add(int amount)
		{
		}

		public bool SetMaxCount(int newMax)
		{
			return false;
		}

		public bool Use(int amount)
		{
			return false;
		}

		protected void RaiseChange(int changeAmount, RegenChangeSource source)
		{
		}

		public abstract void ApplyPendingRegen();

		public abstract float GetSecondsUntilNext();

		public virtual float GetSecondsUntilFull()
		{
			return 0f;
		}

		protected virtual void OnAfterCountChanged()
		{
		}

		public virtual void DebugSetState(int newCount, float secondsUntilNext)
		{
		}
	}
}
