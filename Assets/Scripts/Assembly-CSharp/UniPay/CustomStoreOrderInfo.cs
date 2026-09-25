using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace UniPay
{
	internal class CustomStoreOrderInfo : IOrderInfo
	{
		private readonly string _receipt;

		private readonly string _transactionId;

		public IAppleOrderInfo Apple => null;

		public IGoogleOrderInfo Google => null;

		public IPaymentProvidersOrderInfo PaymentProviders => null;

		public List<IPurchasedProductInfo> PurchasedProductInfo { get; set; }

		public string Receipt => null;

		public string TransactionID => null;

		public CustomStoreOrderInfo(string receipt, string transactionID)
		{
		}
	}
}
