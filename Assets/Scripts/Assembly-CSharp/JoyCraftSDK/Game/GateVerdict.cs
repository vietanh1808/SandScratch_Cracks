using System;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public enum GateVerdict
	{
		Pass = 0,
		InitFailed = 1,
		Offline = 2,
		DownloadFailed = 3,
		PromptRequired = 4,
		ContentKeyMissing = 5,
		SizeCheckFailed = 6
	}
}
