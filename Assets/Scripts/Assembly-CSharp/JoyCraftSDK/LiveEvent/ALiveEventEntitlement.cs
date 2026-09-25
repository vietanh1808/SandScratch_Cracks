using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ALiveEventEntitlement : JBase
	{
		public abstract bool IsPremiumUnlocked { get; }
	}
}
