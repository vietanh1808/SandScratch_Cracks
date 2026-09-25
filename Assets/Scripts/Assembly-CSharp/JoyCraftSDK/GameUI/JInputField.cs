using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(TMP_InputField))]
	public class JInputField : AInputField
	{
		[SerializeField]
		private TMP_InputField inputField;

		private void OnValidate()
		{
		}

		private void ValueChangedAction(string newValue)
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
