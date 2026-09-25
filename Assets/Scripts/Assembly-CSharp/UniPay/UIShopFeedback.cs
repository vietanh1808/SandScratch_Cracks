using System.Collections.Generic;
using UnityEngine;

namespace UniPay
{
	public class UIShopFeedback : MonoBehaviour
	{
		public UIWindowPurchase purchaseWindow;

		public GameObject loadingWindow;

		public UIWindowMessage messageWindow;

		public GameObject confirmWindow;

		public UIWindowPreview previewWindow;

		public static UIShopFeedback Instance { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public static void ShowPurchase(string productID)
		{
		}

		public static void ShowLoading(bool state)
		{
		}

		public static void ShowMessage(string text)
		{
		}

		public static void ShowConfirmation()
		{
		}

		public static void ShowPreview(List<KeyValuePairStringInt> products)
		{
		}

		private void HandlePurchaseStarted(string productId)
		{
		}

		private void HandleSuccessfulPurchase(string productId)
		{
		}

		private void HandleFailedPurchase(string error)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
