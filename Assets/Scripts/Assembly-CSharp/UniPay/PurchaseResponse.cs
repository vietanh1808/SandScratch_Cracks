using System;

namespace UniPay
{
	[Serializable]
	public struct PurchaseResponse
	{
		public int status;

		public string type;

		public int expiresDate;

		public bool autoRenew;

		public bool billingRetry;

		public string productId;

		public bool sandbox;
	}
}
