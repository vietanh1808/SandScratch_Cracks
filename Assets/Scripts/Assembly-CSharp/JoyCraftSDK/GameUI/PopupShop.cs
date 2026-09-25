namespace JoyCraftSDK.GameUI
{
	public class PopupShop : JUIPanel
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
	}
}
