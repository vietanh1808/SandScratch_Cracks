using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Localization.Tests
{
	public class TestLocalizationLanguageDropdown : JMonoBehaviour
	{
		[FormerlySerializedAs("dropdownEventsHandler")]
		[SerializeField]
		private ADropdown dropdownEvents;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDropdownValueChange(int newValue)
		{
		}
	}
}
