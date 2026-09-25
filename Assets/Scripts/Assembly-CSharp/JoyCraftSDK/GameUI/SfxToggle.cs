using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class SfxToggle : JToggle
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
