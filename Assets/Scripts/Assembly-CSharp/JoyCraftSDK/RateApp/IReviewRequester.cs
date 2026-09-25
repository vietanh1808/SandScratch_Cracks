namespace JoyCraftSDK.RateApp
{
	public interface IReviewRequester
	{
		bool IsAvailable { get; }

		void RequestReview();
	}
}
