using System;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public class LoseOfferData : JBase
	{
		[IAPProductID]
		[SerializeField]
		private string productID;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private string titleKey;

		[SerializeField]
		private string descKey;

		public string ProductID => null;

		public Sprite Icon => null;

		public string TitleKey => null;

		public string DescKey => null;
	}
}
