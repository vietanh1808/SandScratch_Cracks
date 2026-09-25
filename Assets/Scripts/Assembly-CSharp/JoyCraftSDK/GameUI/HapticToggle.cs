using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HapticToggle : JToggle
	{
		[SerializeField]
		private SettingToggleAnim toggleAnim;

		protected override void OnToggleValueChanged(bool newValue)
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
