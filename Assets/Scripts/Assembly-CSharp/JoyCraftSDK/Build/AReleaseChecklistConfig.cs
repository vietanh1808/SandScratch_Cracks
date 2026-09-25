using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Build
{
	public abstract class AReleaseChecklistConfig : JScriptableObject
	{
		public abstract int LastReleasedBundleVersionCode { get; set; }

		public abstract int IosBuildNumber { get; set; }

		public abstract string FirebaseAndroidAppId { get; }

		public abstract string FirebaseRemoteConfigUrl { get; }

		public abstract string SymbolUploadLogPath { get; }

		public abstract bool AutoUploadSymbolsToFirebase { get; }

		public abstract List<AfterBuildReminder> AfterBuildReminders { get; }
	}
}
