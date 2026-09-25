using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class ADropdown : JMonoBehaviour
	{
		public readonly Relay<int> OnValueChange;
	}
}
