using System.Collections.Generic;
using JoyCraftSDK.Analytics;

namespace JTD
{
	public sealed class JTDRollupEvent : JAnalyticEvent
	{
		private readonly List<string> _dimKeys;

		private readonly List<string> _sumKeys;

		public IReadOnlyList<string> DimKeys => null;

		public IReadOnlyList<string> SumKeys => null;

		public JTDRollupEvent(string eventName, bool includeUserId = true)
			: base(null, includeUserId: false)
		{
		}

		public JTDRollupEvent Dim(string key, string value)
		{
			return null;
		}

		public JTDRollupEvent Dim(string key, int value)
		{
			return null;
		}

		public JTDRollupEvent Dim(string key, long value)
		{
			return null;
		}

		public JTDRollupEvent Sum(string key, int value)
		{
			return null;
		}

		public JTDRollupEvent Sum(string key, long value)
		{
			return null;
		}

		public JTDRollupEvent Sum(string key, float value)
		{
			return null;
		}

		public JTDRollupEvent Sum(string key, double value)
		{
			return null;
		}
	}
}
