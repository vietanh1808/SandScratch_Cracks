using System;
using AdjustSdk;

namespace JoyCraftSDK
{
	public class AdjustManager : AAdjustManager
	{
		private const AdjustEnvironment environment = AdjustEnvironment.Production;

		private const AdjustLogLevel logLevel = AdjustLogLevel.Suppress;

		public const string ADJUST_DISABLED_PREF = "admin_adjust_disabled";

		private AdjustRevenuePartyGate _partyGate;

		public override void Init()
		{
		}

		public override void RequestTrackingAuthorization(Action onDone)
		{
		}

		private void OnAttributionChanged(AdjustAttribution attribution)
		{
		}

		public override void TrackIAP(string productId, string purchaseToken, double price, string currency)
		{
		}

		private void OnPurchaseVerificationResult(AdjustPurchaseVerificationResult result)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnIAPTransactionTracking(ref AEventManager.IAPTransactionTrackingEvent eventData)
		{
		}

		private void OnAdsRevenueTracking(ref AEventManager.AdsRevenueTrackingEvent eventData)
		{
		}
	}
}
