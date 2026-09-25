using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public interface IBooster
	{
		bool DeferCompletion { get; }

		BoosterType GetBoosterType();

		void TryExecute();

		void RevokeExecution();

		void CompleteExecution();
	}
}
