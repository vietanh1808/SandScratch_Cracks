using System.Collections.Generic;

namespace JoyCraftSDK.IAP
{
	public static class RestorePolicyMap
	{
		private static readonly Dictionary<RewardKind, RestorePolicy> Map;

		public static IReadOnlyDictionary<RewardKind, RestorePolicy> Declared => null;

		public static bool TryGetPolicy(RewardKind kind, out RestorePolicy policy)
		{
			policy = default;
			return false;
		}
	}
}
