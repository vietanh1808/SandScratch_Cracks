using System.Collections.Generic;

namespace JoyCraftSDK.IAP
{
	public static class RestoreReconciler
	{
		public static List<RestoreGrant> BuildPurchaseEntitlementGrants(string productID, GetEntitlementsDelegate getEntitlements)
		{
			return null;
		}

		public static List<RestoreGrant> BuildPlan(IReadOnlyList<string> ownedProductIDs, TryGetRewardEntriesDelegate tryGetRewardEntries, GetEntitlementsDelegate getEntitlements)
		{
			return null;
		}
	}
}
