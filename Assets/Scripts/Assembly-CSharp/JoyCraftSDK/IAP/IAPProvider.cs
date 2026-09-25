using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JoyCraftSDK.IAP
{
	public class IAPProvider : AIAPProvider
	{
		[Serializable]
		private struct GoogleReceiptPayload
		{
			public string json;

			public string signature;
		}

		[Serializable]
		private struct GooglePurchaseData
		{
			public string purchaseToken;
		}

		private const float RESTORE_TIMEOUT_SECONDS = 15f;

		[CompilerGenerated]
		private new Action<string> m_PurchaseSucceeded;

		[CompilerGenerated]
		private new Action<string> m_PurchaseFailed;

		[CompilerGenerated]
		private new Action<bool> m_RestoreFinished;

		[CompilerGenerated]
		private new Action m_StoreInitialized;

		[CompilerGenerated]
		private new Action m_ShopRefreshed;

		public override event Action<string> PurchaseSucceeded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<string> PurchaseFailed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<bool> RestoreFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action StoreInitialized
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action ShopRefreshed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnUniPaySucceeded(string productID)
		{
		}

		private void OnUniPayFailed(string error)
		{
		}

		private void OnUniPayRestore(bool success)
		{
		}

		private void OnUniPayInitialized()
		{
		}

		public override void Purchase(string productID)
		{
		}

		public override void RestoreTransactions(Action<RestoreResult, int> onFinished)
		{
		}

		public override bool IsPurchased(string productID)
		{
			return false;
		}

		public override bool IsInCatalog(string productID)
		{
			return false;
		}

		public override bool IsNonConsumable(string productID)
		{
			return false;
		}

		public override bool IsRealMoneyNonConsumable(string productID)
		{
			return false;
		}

		public override bool IsRealMoney(string productID)
		{
			return false;
		}

		public override bool TryGetPlayerDataInt(string keyID, out int value)
		{
			value = default;
			return false;
		}

		public override void SetPlayerDataInt(string keyID, int value)
		{
		}

		public override void RefreshShop()
		{
		}

		public override bool TryGetStoreMetadata(string productID, out double price, out string currency)
		{
			price = default;
			currency = null;
			return false;
		}

		public override bool TryGetTransactionId(string productID, out string transactionId)
		{
			transactionId = null;
			return false;
		}

		public override bool TryGetReceipt(string productID, out string receiptData)
		{
			receiptData = null;
			return false;
		}

		private static string ExtractGooglePurchaseToken(string payload)
		{
			return null;
		}

		public override string GetProductTitle(string productID)
		{
			return null;
		}

		public override string GetProductPriceLabel(string productID)
		{
			return null;
		}

		public override bool TryGetRewardEntries(string productID, out IReadOnlyList<IAPRewardEntry> entries)
		{
			entries = null;
			return false;
		}

		public override IReadOnlyList<string> GetOwnedProductIDs()
		{
			return null;
		}

		public override void ConsumeOwnedFromVendor(string productID)
		{
		}

		public static string[] GetAllProductIDs()
		{
			return null;
		}
	}
}
