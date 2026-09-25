using JoyCraftSDK.Game.SaveData;

namespace JoyCraftSDK.Game
{
	public class DeadlineBuffInstance : ATimedBuffInstance
	{
		public DeadlineBuffInstance(BuffType type, SavedBuffPoint savedBuffPoint, ATimedBuffService timedBuffService)
			: base(BuffType.None, null, null)
		{
		}

		public override void Activate(float durationSeconds, float magnitude)
		{
		}

		public override bool IsActive()
		{
			return false;
		}

		public override float GetRemainingSeconds()
		{
			return 0f;
		}

		public override void ApplyAntiCheatClamp()
		{
		}
	}
}
