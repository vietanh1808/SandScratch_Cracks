using System;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public enum GatePreCheckResult
	{
		Pass = 0,
		NeedDownload = 1,
		Offline = 2,
		InitFailed = 3,
		ContentKeyMissing = 4,
		SizeCheckFailed = 5
	}
}
