using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class BoosterType4 : JBase, IBooster
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
