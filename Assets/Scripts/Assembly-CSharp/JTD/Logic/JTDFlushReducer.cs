using System.Collections.Generic;

namespace JTD.Logic
{
	internal static class JTDFlushReducer
	{
		private static readonly IReadOnlyList<string> NoIds;

		private static readonly IReadOnlyList<EventContext> NoEvents;

		internal static FlushDecision Decide(QueueSnapshot snap, HttpResult res, RetryState st)
		{
			return null;
		}

		internal static RevenueEnqueuePlan DecideRevenueEnqueue(EventContext rev)
		{
			return null;
		}

		private static bool IsEmpty<T>(IReadOnlyList<T> list)
		{
			return false;
		}

		private static IReadOnlyList<string> InFlightIds(IReadOnlyList<EventContext> inFlight)
		{
			return null;
		}

		private static int LifetimeCount(EventContext e, RetryState st)
		{
			return 0;
		}
	}
}
