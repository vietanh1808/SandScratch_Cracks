using System;

namespace JoyCraftSDK
{
	public class RemoteConfigManager : ARemoteConfigManager
	{
		private const string EmptyJsonObject = "{}";

		private bool _isPersistedConfigReady;

		public override string LevelVariantOverridesJson => null;

		public override void Init(Action onComplete = null)
		{
		}

		private void ActivateRetrievedRemoteConfigValues(Action onComplete = null)
		{
		}
	}
}
