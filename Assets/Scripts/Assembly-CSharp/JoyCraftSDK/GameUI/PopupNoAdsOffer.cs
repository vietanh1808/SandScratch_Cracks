namespace JoyCraftSDK.GameUI
{
	public class PopupNoAdsOffer : JUIPanel
	{
		private float showTime;

		public string PlacementVocab { get; private set; }

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public override void OnAppear()
		{
		}

		public override void OnDisappear()
		{
		}

		protected override void OnDisable()
		{
		}

		private void RaiseIapClose()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnPurchaseNoAdsHandler(ref AEventManager.OnPurchaseNoAds eventData)
		{
		}
	}
}
