using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public abstract class ASlider : JMonoBehaviour
	{
		public Relay<float> OnValueChange;

		public abstract Slider GetSlider();
	}
}
