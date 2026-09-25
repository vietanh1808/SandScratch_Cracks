using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class AWinFlowController : JMonoBehaviour
	{
		public abstract int GetWinCoinAmount();

		public abstract bool IsMonetizeLevel();

		public abstract void ShowContinueAd(Action onClosed);

		public abstract void CompleteContinueMonetize();

		public abstract void GoHome();

		public abstract void TryShowNoAdsOffer();
	}
}
