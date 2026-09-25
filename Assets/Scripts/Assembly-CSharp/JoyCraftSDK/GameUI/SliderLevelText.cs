using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class SliderLevelText : JMonoBehaviour
	{
		[SerializeField]
		private ASliderWithTexts _sliderWithTexts;

		[SerializeField]
		private int maxLevelTxt;

		public override void Awake()
		{
		}

		private void InitSlider()
		{
		}

		private void OnValueChange(float value)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
