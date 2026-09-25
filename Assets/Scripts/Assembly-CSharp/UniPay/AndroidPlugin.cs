using System.ComponentModel;

namespace UniPay
{
	public enum AndroidPlugin
	{
		[Description(null)]
		UnityIAP = 0,
		[Description("OCULUS_IAP")]
		Oculus = 1,
		[Description("AMAZON_IAP")]
		Amazon = 2
	}
}
