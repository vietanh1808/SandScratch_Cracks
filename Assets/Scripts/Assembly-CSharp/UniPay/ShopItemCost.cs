using System;
using TMPro;
using UnityEngine;

namespace UniPay
{
	[Serializable]
	public class ShopItemCost
	{
		public IAPExchangeObject.ExchangeType type;

		[SerializeReference]
		public IAPCurrency currency;

		public TMP_Text label;
	}
}
