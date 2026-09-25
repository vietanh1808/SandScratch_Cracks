using System;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public class ShopCardEntry : JBase
	{
		private const string Group_Shop = "Shop";

		private const string Group_Lose = "Lose Offer";

		[SerializeField]
		private JShopCV card;

		[IAPProductID]
		[SerializeField]
		private string gateProductID;

		[SerializeField]
		private ShopUnlockRule unlockRule;

		[SerializeField]
		private bool showOnLose;

		[SerializeField]
		private Sprite loseCardArt;

		[SerializeField]
		private bool playOnAfterPurchase;

		public JShopCV Card => null;

		public string GateProductID => null;

		public ShopUnlockRule UnlockRule => ShopUnlockRule.Always;

		public bool ShowOnLose => false;

		public Sprite LoseCardArt => null;

		public bool PlayOnAfterPurchase => false;
	}
}
