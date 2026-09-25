using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class ATabBtn : JButton
	{
		public abstract void SetPage(ATabPage page);

		public abstract void SetPageActive(bool active);

		public abstract void SetOnClickAction(Action<ATabBtn> action);

		public abstract void OnSelect();

		public abstract void OnDeselect();
	}
}
