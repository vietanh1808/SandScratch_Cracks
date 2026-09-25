using System.ComponentModel;

namespace UniPay
{
	public enum WebPlugin
	{
		[Description(null)]
		UnityIAP = 0,
		[Description("PAYPAL_IAP")]
		PayPal = 1
	}
}
