using System.ComponentModel;

namespace UniPay
{
	public enum DesktopPlugin
	{
		[Description(null)]
		UnityIAP = 0,
		[Description("OCULUS_IAP")]
		Oculus = 1,
		[Description("STEAM_IAP")]
		Steam = 2,
		[Description("PAYPAL_IAP")]
		PayPal = 3
	}
}
