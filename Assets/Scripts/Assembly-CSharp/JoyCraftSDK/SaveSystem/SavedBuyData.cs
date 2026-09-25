using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBuyData : JSaveData
	{
		public const int MaxVersion_SavedBuyData = 1;

		[SerializeField]
		private bool buyNoAds;

		[SerializeField]
		private bool rated;

		[SerializeField]
		private bool shownNoAdsOffer;

		[SerializeField]
		private List<string> ownedProductIDs;

		[SerializeField]
		private int iapCount;

		public bool BuyNoAds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Rated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShownNoAdsOffer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IReadOnlyList<string> OwnedProductIDs => null;

		public int IapCount => 0;

		public bool IsProductOwned(string productID)
		{
			return false;
		}

		public void AddOwnedProduct(string productID)
		{
		}

		public void ClearOwnedProducts()
		{
		}

		public void IncrementIapCount()
		{
		}

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}
	}
}
