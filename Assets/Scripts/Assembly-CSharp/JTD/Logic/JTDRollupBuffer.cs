using System.Collections.Generic;

namespace JTD.Logic
{
	internal sealed class JTDRollupBuffer
	{
		internal sealed class Bucket
		{
			public string EventName;

			public List<KeyValuePair<string, string>> Dims;

			public long Count;

			public Dictionary<string, double> Sums;

			public long FirstTsMs;

			public long LastTsMs;

			public Dictionary<string, object> ToProperties()
			{
				return null;
			}
		}

		internal const string RollupCountKey = "rollup_count";

		internal const string FirstTsKey = "first_ts";

		internal const string LastTsKey = "last_ts";

		internal const int DefaultBucketCap = 50;

		internal const int DefaultCountCap = 500;

		internal const string OverflowMarker = "_overflow";

		private const char Sep = '\u001f';

		private readonly Dictionary<string, Bucket> _buckets;

		private readonly int _bucketCap;

		private readonly int _countCap;

		internal bool Overflowed { get; private set; }

		internal int BucketCount => 0;

		internal JTDRollupBuffer(int bucketCap = 50, int countCap = 500)
		{
		}

		internal Bucket Add(string eventName, IList<KeyValuePair<string, string>> dims, IDictionary<string, double> sums, long tsMs)
		{
			return null;
		}

		internal List<Bucket> DrainAll()
		{
			return null;
		}

		private Bucket AddToOverflow(string eventName, IDictionary<string, double> sums, long tsMs)
		{
			return null;
		}

		private static Bucket CreateBucket(string eventName, List<KeyValuePair<string, string>> dims, long tsMs)
		{
			return null;
		}

		private Bucket TryFlushEarly(string key, Bucket bucket)
		{
			return null;
		}

		private static void Accumulate(Bucket bucket, IDictionary<string, double> sums, long tsMs)
		{
		}

		private static List<KeyValuePair<string, string>> SortDims(IList<KeyValuePair<string, string>> dims)
		{
			return null;
		}

		private static string BuildKey(string eventName, List<KeyValuePair<string, string>> sortedDims)
		{
			return null;
		}
	}
}
