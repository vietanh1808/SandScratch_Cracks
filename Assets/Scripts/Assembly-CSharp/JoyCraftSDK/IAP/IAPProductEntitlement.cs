using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	public class IAPProductEntitlement : JBase
	{
		[IAPProductID]
		[SerializeField]
		private string productID;

		[SerializeField]
		private List<IAPEntitlement> entitlements;

		public string ProductID => null;

		public IReadOnlyList<IAPEntitlement> Entitlements => null;
	}
}
