using System;

namespace UniPay
{
	[Serializable]
	public class PayPalStoreConfig
	{
		[Serializable]
		public class Credentials
		{
			public string clientID;

			public string secretKey;
		}

		public string currencyCode;

		public Credentials sandbox;

		public Credentials live;

		public string returnUrl;
	}
}
