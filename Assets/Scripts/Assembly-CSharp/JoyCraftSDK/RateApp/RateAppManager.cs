using JoyCraftSDK.SaveSystem;

namespace JoyCraftSDK.RateApp
{
	public class RateAppManager : ARateAppManager
	{
		private readonly IReviewRequester _reviewRequester;

		private bool _subscribed;

		private SavedRateAppData savedRateAppData => null;

		private ARateAppConfig config => null;

		public override void Initialize()
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		public override void TryRequestReview(RateTrigger trigger)
		{
		}

		private bool CanRequest(long nowTicks, string appVersion)
		{
			return false;
		}
	}
}
