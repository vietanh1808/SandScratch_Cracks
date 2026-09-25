using JoyCraftSDK.LiveEvent;

namespace JoyCraftSDK.GameUI
{
	public class PopupBattlePassPremium : JUIPanel
	{
		private float showTime;

		private ABattlePassManager _battlePassManager => null;

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

		protected override void RegisterEvent()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		private void OnPremiumUnlocked(ref AEventManager.OnLiveEventPremiumUnlocked eventData)
		{
		}
	}
}
