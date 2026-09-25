using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Slider))]
	public class JSlider : ASlider
	{
		[SerializeField]
		private Slider slider;

		private void OnValidate()
		{
		}

		private void ValueChangedAction(float newValue)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public override Slider GetSlider()
		{
			return null;
		}
	}
}
