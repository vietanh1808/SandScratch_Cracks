using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedBuffInstance : JBase
	{
		private readonly BuffType type;

		private readonly SavedBuffPoint savedBuffPoint;

		protected readonly ATimedBuffService timedBuffService;

		public BuffType Type => BuffType.None;

		public float Magnitude => 0f;

		protected long startUtcTicks
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		protected long durationTicks
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		protected float magnitude
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected ATimedBuffInstance(BuffType type, SavedBuffPoint savedBuffPoint, ATimedBuffService timedBuffService)
		{
		}

		public abstract void Activate(float durationSeconds, float magnitude);

		public abstract bool IsActive();

		public abstract float GetRemainingSeconds();

		public abstract void ApplyAntiCheatClamp();
	}
}
