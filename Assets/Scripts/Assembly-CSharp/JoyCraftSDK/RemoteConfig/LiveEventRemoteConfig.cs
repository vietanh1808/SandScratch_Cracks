using System;

namespace JoyCraftSDK.RemoteConfig
{
	[Serializable]
	public class LiveEventRemoteConfig
	{
		public bool bpEnabled;

		public bool IsBattlePassEnabled()
		{
			return false;
		}
	}
}
