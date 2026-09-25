using Google.Play.Review;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.RateApp
{
	public class AndroidReviewRequester : JBase, IReviewRequester
	{
		private ReviewManager _reviewManager;

		public bool IsAvailable => false;

		public void RequestReview()
		{
		}
	}
}
