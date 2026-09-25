using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public abstract class ASliderWithTexts : JMonoBehaviour
	{
		public Relay<float> OnValueChange;

		public abstract Slider GetSlider();

		public abstract void SetupTexts();
	}
}
