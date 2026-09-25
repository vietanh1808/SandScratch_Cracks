using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.IAP
{
	public abstract class AIAPBuyService : JBase
	{
		public abstract void Buy(string productID, string placement, string showType, string triggerType, Action onComplete, Action onFail);

		public virtual bool IsOTPOwned(string productID)
		{
			return false;
		}

		public virtual bool IsOTPLocked(string productID)
		{
			return false;
		}

		public virtual void SyncOwnedFromVendor()
		{
		}

		public virtual void ResetOTPOwnership()
		{
		}
	}
}
