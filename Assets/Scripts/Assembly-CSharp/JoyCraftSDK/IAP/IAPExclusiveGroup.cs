using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	public class IAPExclusiveGroup : JBase
	{
		[SerializeField]
		private string groupID;

		[IAPProductID]
		[SerializeField]
		private List<string> productIDs;

		public string GroupID => null;

		public IReadOnlyList<string> ProductIDs => null;

		public bool Contains(string productID)
		{
			return false;
		}
	}
}
