using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class AToggleEvents : JMonoBehaviour
	{
		public Relay<bool> OnValueChange;

		public abstract void SetValueWithoutInvoke(bool newValue);

		public abstract bool IsOn();
	}
}
