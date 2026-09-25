using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.RateApp
{
	public abstract class ARateAppManager : JBase
	{
		public abstract void Initialize();

		public abstract void TryRequestReview(RateTrigger trigger);
	}
}
