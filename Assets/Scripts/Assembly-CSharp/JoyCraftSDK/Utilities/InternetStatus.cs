using System;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public enum InternetStatus
	{
		PendingCheck = 0,
		NotConnected = 1,
		Restricted = 2,
		Connected = 3
	}
}
