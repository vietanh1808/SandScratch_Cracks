using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelSwapController : JMonoBehaviour
	{
		public abstract ALevelRangeSwapConfig SwapConfig { get; }

		public abstract bool TryHandleWin();
	}
}
