using System.Collections.Generic;

namespace JTD.Logic
{
	internal static class JTDQueuePolicy
	{
		internal const int QueueCap = 1000;

		internal const long MaxAgeMs = 604800000L;

		internal static readonly HashSet<string> RevenueEvents;

		internal static bool IsRevenue(EventContext e)
		{
			return false;
		}

		internal static bool IsRollupSummary(EventContext e)
		{
			return false;
		}

		internal static bool IsProtected(EventContext e)
		{
			return false;
		}

		internal static EventContext EnforceCapOnEnqueue(List<EventContext> queue, int cap = 1000)
		{
			return null;
		}

		internal static List<EventContext> TakeNonRevenueBatch(List<EventContext> queue, int max)
		{
			return null;
		}

		internal static List<EventContext> EvictExpired(List<EventContext> queue, long nowMs, long maxAgeMs = 604800000L)
		{
			return null;
		}
	}
}
