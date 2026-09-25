using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	[CreateAssetMenu(fileName = "IAPEntitlementConfig", menuName = "JoyCraft/Configs/IAPEntitlementConfig")]
	public class IAPEntitlementConfig : AIAPEntitlementConfig
	{
		[SerializeField]
		private List<IAPProductEntitlement> entries;

		public override IReadOnlyList<IAPProductEntitlement> Entries => null;

		public override IReadOnlyList<IAPEntitlement> GetEntitlements(string productID)
		{
			return null;
		}
	}
}
