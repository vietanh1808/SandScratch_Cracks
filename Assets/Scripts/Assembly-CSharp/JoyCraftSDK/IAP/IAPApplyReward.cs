using System.Collections.Generic;
using JoyCraftSDK.Rewards;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	public class IAPApplyReward : JMonoBehaviour
	{
		private const string Group_ProductIDs = "Product IDs";

		[IAPProductID]
		[SerializeField]
		private string subMonthlyProductID;

		[IAPProductID]
		[SerializeField]
		private string subYearlyProductID;

		private RewardGranter _rewardGranter;

		private const string LEVEL_REQUIREMENT = "level";

		private RewardGranter RewardGranter => null;

		private IReadOnlyList<IAPEntitlement> GetEntitlements(string productID)
		{
			return null;
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnLevelFinishedHandler(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnPurchaseSuccess(string productID)
		{
		}

		private static bool GrantsCurrency(IReadOnlyList<IAPRewardEntry> rewards)
		{
			return false;
		}

		private void ShowRewardPopup(IReadOnlyList<IAPRewardEntry> rewards)
		{
		}

		private void TrackPurchaseBI(string productID)
		{
		}

		private static PaymentGateway GetPaymentGateway()
		{
			return PaymentGateway.Sandbox;
		}

		private static string ToWireString(PaymentGateway gateway)
		{
			return null;
		}

		private static string GenerateTransactionID()
		{
			return null;
		}

		private static string GetProductSlug(string productID)
		{
			return null;
		}

		private void OnRestoreFinished(bool success)
		{
		}

		private void OnStoreInitialized()
		{
		}

		private void SyncOwnershipFromVendor()
		{
		}

		private static string JoinProductIDs(IReadOnlyList<string> productIDs)
		{
			return null;
		}

		private void ApplyProductByID(string productID)
		{
		}
	}
}
