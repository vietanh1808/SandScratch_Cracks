using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.ExternalLink
{
	public abstract class AExternalLinkConfig : JScriptableObject
	{
		public abstract string GetUrl(ExternalLinkID linkID);
	}
}
