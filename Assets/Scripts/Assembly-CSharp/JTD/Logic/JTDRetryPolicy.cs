namespace JTD.Logic
{
	internal static class JTDRetryPolicy
	{
		internal const int RetryMaxPerFlush = 3;

		internal const int RetryLifetimeCap = 100;

		internal static HttpResult Classify(int statusCode, bool networkError = false)
		{
			return HttpResult.None;
		}

		internal static bool CountsTowardRetry(HttpResult result)
		{
			return false;
		}

		internal static bool ExceededFlushRetryCap(int attempt, int maxRetries = 3)
		{
			return false;
		}

		internal static bool IsPoison(int retryCount, int lifetimeCap = 100)
		{
			return false;
		}
	}
}
