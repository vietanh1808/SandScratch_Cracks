using System;
using UnityEngine;

namespace UniPay
{
	[Serializable]
	public class IAPCurrency
	{
		[HideInInspector]
		public string referenceID;

		public string ID;

		public int baseAmount;

		public int maxAmount;

		public Sprite icon;
	}
}
