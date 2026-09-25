using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AAdjustManager : JMonoBehaviour
	{
		public abstract void Init();

		public abstract void TrackIAP(string productId, string purchaseToken, double price, string currency);

		public abstract void RequestTrackingAuthorization(Action onDone);
	}
}
