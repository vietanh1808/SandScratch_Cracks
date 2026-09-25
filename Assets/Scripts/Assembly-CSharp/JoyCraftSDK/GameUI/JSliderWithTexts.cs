using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class JSliderWithTexts : ASliderWithTexts
	{
		[SerializeField]
		private Slider slider;

		[SerializeField]
		private TextMeshProUGUI txtMin;

		[SerializeField]
		private TextMeshProUGUI txtCurrent;

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

		private void SetupMinText()
		{
		}

		private void SetupCurrentText()
		{
		}

		public override void SetupTexts()
		{
		}
	}
}
