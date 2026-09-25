using System;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public enum RetryState
	{
		None = 0,
		LevelFail = 1,
		LevelQuit = 2,
		LevelRetry = 3
	}
}
