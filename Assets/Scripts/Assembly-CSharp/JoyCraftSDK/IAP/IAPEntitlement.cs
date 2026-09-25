using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	public class IAPEntitlement : JBase
	{
		[SerializeField]
		private RewardKind kind;

		[SerializeField]
		private int amount;

		public RewardKind Kind => RewardKind.None;

		public int Amount => 0;
	}
}
