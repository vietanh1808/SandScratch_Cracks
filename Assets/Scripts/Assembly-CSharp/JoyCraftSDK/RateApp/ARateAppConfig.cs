using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.RateApp
{
	public abstract class ARateAppConfig : JScriptableObject
	{
		public abstract RatePromptConstraint InitialConstraint { get; }

		public abstract RatePromptConstraint RepeatConstraint { get; }

		public abstract string StoreIdOverride { get; }
	}
}
