using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace UniPay
{
	internal class PayPalStoreWrapper : IStoreWrapper
	{
		private PayPalStore store;

		public string name { get; }

		private string Name => null;

		public Store instance => null;

		public PayPalStoreWrapper(PayPalStore instance)
		{
		}

		public ConnectionState GetStoreConnectionState()
		{
			return ConnectionState.Disconnected;
		}
	}
}
