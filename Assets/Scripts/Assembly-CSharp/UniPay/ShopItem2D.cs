using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UniPay
{
	public class ShopItem2D : MonoBehaviour
	{
		[Header("Metadata")]
		public string productID;

		public TMP_Text title;

		public TMP_Text description;

		public Image icon;

		public bool uppercase;

		public bool askToBuy;

		[Header("Inventory")]
		public TMP_Text amount;

		public TMP_Text expiration;

		[Header("Buttons")]
		public GameObject buyButton;

		public GameObject previewButton;

		public GameObject selectButton;

		public GameObject deselectButton;

		[Header("Unlocks")]
		public TMP_Text lockedLabel;

		public GameObject[] hideOnUnlock;

		public GameObject[] showOnUnlock;

		[Header("States")]
		public GameObject discounted;

		public GameObject sold;

		public GameObject selected;

		[HideInInspector]
		public List<ShopItemCost> costs;

		private Toggle selCheck;

		private bool IsInitialized;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void Init(IAPProduct product)
		{
		}

		public virtual void OverwriteWithFetch()
		{
		}

		public virtual void Refresh()
		{
		}

		public void Unlock()
		{
		}

		public void ShowPreview()
		{
		}

		public void Purchase()
		{
		}

		public virtual void Purchased(bool state)
		{
		}

		public void IsSelected(bool thisSelect)
		{
		}

		public void Deselect()
		{
		}
	}
}
