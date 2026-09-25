using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.IAP
{
	public abstract class AIAPEntitlementConfig : JScriptableObject
	{
		public abstract IReadOnlyList<IAPProductEntitlement> Entries { get; }

		public abstract IReadOnlyList<IAPEntitlement> GetEntitlements(string productID);
	}
}
