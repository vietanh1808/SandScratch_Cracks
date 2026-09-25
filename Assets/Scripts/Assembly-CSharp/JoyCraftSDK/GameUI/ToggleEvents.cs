using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Toggle))]
	public class ToggleEvents : AToggleEvents
	{
		[SerializeField]
		private Toggle toggle;

		private bool _ignoreValueChange;

		public override void SetValueWithoutInvoke(bool newValue)
		{
		}

		public override bool IsOn()
		{
			return false;
		}

		private void ValueChangedAction(bool isOn)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnValidate()
		{
		}
	}
}
