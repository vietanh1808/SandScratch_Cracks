using UnityEngine;

namespace TouchScript.Devices.Display
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Devices_Display_GenericDisplayDevice.htm")]
	public class GenericDisplayDevice : DisplayDevice
	{
		private static bool? isLaptop;

		private static bool IsLaptop => false;

		public override void UpdateDPI()
		{
		}

		protected override void OnEnable()
		{
		}

		private void updateNativeResulotion()
		{
		}

		private void updateNativeDPI()
		{
		}

		private bool getHighestResolution(out Vector2 resolution)
		{
			resolution = default;
			return false;
		}
	}
}
