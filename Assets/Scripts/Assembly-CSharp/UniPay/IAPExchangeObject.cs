using System;
using UnityEngine;

namespace UniPay
{
	[Serializable]
	public class IAPExchangeObject
	{
		public enum ExchangeType
		{
			RealMoney = 0,
			VirtualCurrency = 1,
			VirtualProduct = 2
		}

		public ExchangeType type;

		[SerializeReference]
		public IAPCurrency currency;

		[SerializeReference]
		public IAPProduct product;

		public int amount;

		public string realPrice;
	}
}
