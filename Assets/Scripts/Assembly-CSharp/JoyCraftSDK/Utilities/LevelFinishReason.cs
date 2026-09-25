using System;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public enum LevelFinishReason
	{
		None = 0,
		Completed = 1,
		Failed = 2,
		Quit = 3,
		Exit = 4
	}
}
