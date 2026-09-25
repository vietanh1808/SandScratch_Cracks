using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ACurtain : JMonoBehaviour
	{
		public abstract void Setup();

		public abstract void ScrollUp(float progress);

		public abstract void Pause();

		public abstract void ScrollComplete();
	}
}
