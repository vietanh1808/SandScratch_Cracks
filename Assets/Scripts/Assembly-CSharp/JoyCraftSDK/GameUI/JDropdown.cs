using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(TMP_Dropdown))]
	public class JDropdown : ADropdown
	{
		[SerializeField]
		private TMP_Dropdown dropdown;

		private void OnValidate()
		{
		}

		public TMP_Dropdown GetDropdown()
		{
			return null;
		}

		private void ValueChangedAction(int newValue)
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
