using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ABackGroundFadeBooster : JMonoBehaviour
	{
		public abstract void Show(Action onDone);

		public abstract void Hide();
	}
}
