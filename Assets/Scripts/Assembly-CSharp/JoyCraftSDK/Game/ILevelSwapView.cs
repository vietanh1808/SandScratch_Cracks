using System.Collections.Generic;

namespace JoyCraftSDK.Game
{
	public interface ILevelSwapView
	{
		IReadOnlyList<SwapElement> DetachOutgoing();

		IReadOnlyList<SwapElement> BuildIncoming(ALevelData next);

		void FinalizeIncoming();

		void DisposeOutgoing();

		void AbortSwap();
	}
}
