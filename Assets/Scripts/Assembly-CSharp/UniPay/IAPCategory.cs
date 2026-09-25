using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniPay
{
	[Serializable]
	public class IAPCategory
	{
		[HideInInspector]
		public string referenceID;

		public string ID;

		public List<StoreMetaDefinition> storeIDs;
	}
}
