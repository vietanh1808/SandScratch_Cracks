using System;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public enum BandPrefetchVerdict
	{
		Skip = 0,
		Download = 1,
		NeedConsent = 2,
		ContentUnavailable = 3
	}
}
