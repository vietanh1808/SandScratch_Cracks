using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class AButtonAnimController : JMonoBehaviour
	{
		public abstract void Show(bool instant = false);

		public abstract void Hide(bool instant = false);

		public abstract bool IsShowing();
	}
}
