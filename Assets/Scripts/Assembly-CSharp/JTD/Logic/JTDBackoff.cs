using System;

namespace JTD.Logic
{
	internal static class JTDBackoff
	{
		internal const int ClampMinMs = 1000;

		internal const int ClampMaxMs = 120000;

		internal const double JitterFraction = 0.2;

		internal static int ExponentialMs(int attempt)
		{
			return 0;
		}

		internal static int ApplyJitter(int ms, double rand01)
		{
			return 0;
		}

		internal static int BackoffWithJitter(int attempt, double rand01)
		{
			return 0;
		}

		internal static int RetryAfterMs(string header, int attempt, DateTimeOffset now, double rand01)
		{
			return 0;
		}

		internal static bool TryParseRetryAfterSeconds(string header, DateTimeOffset now, out double seconds)
		{
			seconds = default;
			return false;
		}

		private static int Clamp(long ms)
		{
			return 0;
		}
	}
}
