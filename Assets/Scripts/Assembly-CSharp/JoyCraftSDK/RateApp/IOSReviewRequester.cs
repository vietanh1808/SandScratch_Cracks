using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.RateApp
{
	public class IOSReviewRequester : JBase, IReviewRequester
	{
		public bool IsAvailable => false;

		public void RequestReview()
		{
		}
	}
}
