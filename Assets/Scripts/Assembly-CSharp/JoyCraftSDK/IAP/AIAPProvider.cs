using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.IAP
{
	public abstract class AIAPProvider : JBase
	{
		public abstract event Action<string> PurchaseSucceeded;

		public abstract event Action<string> PurchaseFailed;

		public abstract event Action<bool> RestoreFinished;

		public abstract event Action StoreInitialized;

		public abstract event Action ShopRefreshed;

		public abstract void Purchase(string productID);

		public void RestoreTransactions(Action<bool> onFinished)
		{
		}

		public abstract void RestoreTransactions(Action<RestoreResult, int> onFinished);

		public abstract bool IsPurchased(string productID);

		public abstract bool IsInCatalog(string productID);

		public abstract bool IsNonConsumable(string productID);

		public abstract bool IsRealMoneyNonConsumable(string productID);

		public abstract bool IsRealMoney(string productID);

		public abstract bool TryGetPlayerDataInt(string keyID, out int value);

		public abstract void SetPlayerDataInt(string keyID, int value);

		public abstract void RefreshShop();

		public abstract bool TryGetStoreMetadata(string productID, out double price, out string currency);

		public abstract bool TryGetTransactionId(string productID, out string transactionId);

		public abstract bool TryGetReceipt(string productID, out string receiptData);

		public abstract string GetProductTitle(string productID);

		public abstract string GetProductPriceLabel(string productID);

		public abstract bool TryGetRewardEntries(string productID, out IReadOnlyList<IAPRewardEntry> entries);

		public abstract IReadOnlyList<string> GetOwnedProductIDs();

		public abstract void ConsumeOwnedFromVendor(string productID);
	}
}
