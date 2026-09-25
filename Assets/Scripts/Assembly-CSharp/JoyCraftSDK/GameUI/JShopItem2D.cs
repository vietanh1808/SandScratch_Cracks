using TMPro;
using UniPay;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JShopItem2D : ShopItem2D
	{
		[SerializeField]
		private TMP_Text statusLabel;

		[SerializeField]
		private GameObject purchasedOverlay;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OverwriteWithFetch()
		{
		}

		public override void Refresh()
		{
		}

		public void PurchaseViaFacade()
		{
		}

		public override void Purchased(bool state)
		{
		}
	}
}
