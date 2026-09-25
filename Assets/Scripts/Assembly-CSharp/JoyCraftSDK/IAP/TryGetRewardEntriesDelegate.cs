using System.Collections.Generic;

namespace JoyCraftSDK.IAP
{
	public delegate bool TryGetRewardEntriesDelegate(string productID, out IReadOnlyList<IAPRewardEntry> entries);
}
