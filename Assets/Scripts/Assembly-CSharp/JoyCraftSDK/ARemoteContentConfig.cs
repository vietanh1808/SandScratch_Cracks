using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ARemoteContentConfig : JScriptableObject
	{
		public abstract IReadOnlyList<ContentGroup> Groups { get; }

		public abstract bool RemoteRewriteEnabled { get; }

		public abstract long PromptThresholdBytes { get; }
	}
}
