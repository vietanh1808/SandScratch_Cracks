using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LoseBundleCard : JMonoBehaviour
	{
		[SerializeField]
		private Image art;

		[SerializeField]
		private BtnBuyBundle buyButton;

		public BtnBuyBundle BuyButton => null;

		public void Bind(string productID, Sprite cardArt, bool playOnAfterPurchase)
		{
		}
	}
}
