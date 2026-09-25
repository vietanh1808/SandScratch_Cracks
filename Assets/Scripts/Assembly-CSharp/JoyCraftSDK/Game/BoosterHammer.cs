using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class BoosterHammer : JBase, IBooster
	{
		public bool DeferCompletion => false;

		public BoosterType GetBoosterType()
		{
			return BoosterType.None;
		}

		public void TryExecute()
		{
		}

		public void RevokeExecution()
		{
		}

		public void CompleteExecution()
		{
		}
	}
}
