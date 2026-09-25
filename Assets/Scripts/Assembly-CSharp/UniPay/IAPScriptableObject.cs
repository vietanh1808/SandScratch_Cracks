using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniPay
{
	[Serializable]
	[ExcludeFromPreset]
	public class IAPScriptableObject : ScriptableObject
	{
		[Serializable]
		public class CustomStoreConfig
		{
			public PayPalStoreConfig PayPal;
		}

		public List<IAPCategory> categoryList;

		public List<IAPCurrency> currencyList;

		public List<IAPProduct> productList;

		public CustomStoreConfig customStoreConfig;
	}
}
