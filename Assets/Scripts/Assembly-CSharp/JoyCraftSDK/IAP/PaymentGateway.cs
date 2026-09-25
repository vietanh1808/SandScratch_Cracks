using System;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	public enum PaymentGateway
	{
		Sandbox = 0,
		GooglePlay = 1,
		AppStore = 2,
		Stripe = 3,
		Manual = 4
	}
}
