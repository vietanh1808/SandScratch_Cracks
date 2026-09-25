using System;
using System.Collections.Generic;

namespace JoyCraftSDK.IAP
{
	public class IAPBuyService : AIAPBuyService
	{
		private readonly Dictionary<string, (Action onComplete, Action onFail)> pendingByProduct;

		private string inFlightProductID;

		private string inFlightPlacement;

		private string inFlightShowType;

		private string inFlightTriggerType;

		private bool isSubscribed;

		public override bool IsOTPOwned(string productID)
		{
			return false;
		}

		public override void SyncOwnedFromVendor()
		{
		}

		public override void ResetOTPOwnership()
		{
		}

		public override bool IsOTPLocked(string productID)
		{
			return false;
		}

		public override void Buy(string productID, string placement, string showType, string triggerType, Action onComplete, Action onFail)
		{
		}

		private (string, string, string, string, int) ClientEnvelope()
		{
			return default;
		}

		private void RaiseIapPurchaseSuccess(string productID, string placement, string showType, string triggerType)
		{
		}

		private void RaiseIapPurchaseFailed(string productID, string placement, string showType, string triggerType, string error)
		{
		}

		private static string MapIapFailReason(string rawError)
		{
			return null;
		}

		private void EnsureSubscribed()
		{
		}

		private void OnPurchaseSucceeded(string productID)
		{
		}

		private void OnPurchaseFailed(string error)
		{
		}

		private void ClearPending(string productID)
		{
		}
	}
}
