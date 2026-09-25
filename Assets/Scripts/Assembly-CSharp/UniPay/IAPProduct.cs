using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

namespace UniPay
{
	[Serializable]
	public class IAPProduct
	{
		[HideInInspector]
		public string referenceID;

		public string ID;

		public List<StoreMetaDefinition> storeIDs;

		[SerializeReference]
		public IAPCategory category;

		public ProductType type;

		public string title;

		public string description;

		public bool discount;

		public bool fetch;

		public Sprite icon;

		public List<IAPExchangeObject> priceList;

		public List<IAPExchangeObject> rewardList;

		public IAPRequirement requirement;

		[SerializeReference]
		public IAPProduct nextUpgrade;

		public string GetStoreID(string store)
		{
			return null;
		}

		public bool IsVirtual()
		{
			return false;
		}

		public string GetPriceString()
		{
			return null;
		}
	}
}
