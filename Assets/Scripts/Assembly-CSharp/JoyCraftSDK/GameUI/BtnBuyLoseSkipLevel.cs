using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnBuyLoseSkipLevel : JButton
	{
		[IAPProductID]
		[SerializeField]
		private string productID;

		public bool IsBundleLocked()
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void ApplyPriceLabel()
		{
		}

		protected override void OnClick()
		{
		}

		private void OnBuyComplete()
		{
		}

		private void OnBuyFail()
		{
		}
	}
}
