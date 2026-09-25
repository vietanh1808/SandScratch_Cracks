using System.Collections.Generic;

namespace JTD.Logic
{
	internal static class JTDRollupPolicy
	{
		private static readonly HashSet<string> RedLineExact;

		private static readonly string[] RedLinePrefixes;

		internal static bool IsRedLine(string eventName)
		{
			return false;
		}
	}
}
