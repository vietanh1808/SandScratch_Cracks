using UnityEngine;

namespace TouchScript.Devices.Display
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Devices_Display_DisplayDevice.htm")]
	public class DisplayDevice : ScriptableObject, IDisplayDevice
	{
		[SerializeField]
		protected new string name;

		[SerializeField]
		protected float dpi;

		[SerializeField]
		protected float nativeDPI;

		[SerializeField]
		protected Vector2 nativeResolution;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual float DPI => 0f;

		public virtual float NativeDPI => 0f;

		public virtual Vector2 NativeResolution => default;

		public virtual void UpdateDPI()
		{
		}

		protected virtual void OnEnable()
		{
		}
	}
}
