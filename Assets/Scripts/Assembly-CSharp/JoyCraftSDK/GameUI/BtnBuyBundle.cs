using System;
using System.Runtime.CompilerServices;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnBuyBundle : JButton
	{
		[IAPProductID]
		[SerializeField]
		private string productID;

		[CompilerGenerated]
		private Action m_OnPurchased;

		private bool playOnAfterPurchase;

		public string ProductID => null;

		public event Action OnPurchased
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetProductID(string newProductID)
		{
		}

		public void SetPlayOnAfterPurchase(bool value)
		{
		}

		public bool IsOwned()
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
