using System;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	public enum RestoreResult
	{
		Success = 0,
		NoItemsToRestore = 1,
		StoreNotReady = 2,
		Failed = 3,
		Timeout = 4
	}
}
