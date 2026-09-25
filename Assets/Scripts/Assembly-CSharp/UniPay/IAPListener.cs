using UnityEngine;

namespace UniPay
{
	public class IAPListener : MonoBehaviour
	{
		private void Start()
		{
		}

		public void HandleSuccessfulPurchase(string productID)
		{
		}

		public void HandleSuccessfulConsume(string productID)
		{
		}

		public void HandleSuccessfulRestore(bool success)
		{
		}

		private void ShowMessage(string text)
		{
		}

		private void HandleFailedPurchase(string error)
		{
		}

		private void HandleFailedConsume(string error)
		{
		}

		private void HandleSelectedItem(string productID)
		{
		}

		private void HandleDeselectedItem(string productID)
		{
		}
	}
}
