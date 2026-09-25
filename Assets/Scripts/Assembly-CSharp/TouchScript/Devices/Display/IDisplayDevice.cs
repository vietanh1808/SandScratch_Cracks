using UnityEngine;

namespace TouchScript.Devices.Display
{
	public interface IDisplayDevice
	{
		string Name { get; }

		float DPI { get; }

		float NativeDPI { get; }

		Vector2 NativeResolution { get; }

		void UpdateDPI();
	}
}
