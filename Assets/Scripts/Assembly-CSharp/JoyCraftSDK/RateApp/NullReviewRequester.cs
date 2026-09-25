using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.RateApp
{
	public class NullReviewRequester : JBase, IReviewRequester
	{
		public bool IsAvailable => false;

		public void RequestReview()
		{
		}
	}
}
