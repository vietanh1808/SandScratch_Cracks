using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class AInputField : JMonoBehaviour
	{
		public Relay<string> OnValueChange;
	}
}
