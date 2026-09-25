using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnBuyNoAds : JButton
	{
		[IAPProductID]
		[SerializeField]
		private string productID;

		private PopupNoAdsOffer hostPopup;

		protected override void OnEnable()
		{
		}

		protected override void OnClick()
		{
		}

		private void OnBuyFail()
		{
		}
	}
}
