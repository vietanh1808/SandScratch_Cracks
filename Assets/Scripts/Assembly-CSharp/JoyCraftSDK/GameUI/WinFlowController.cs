using System;
using JoyCraftSDK.RemoteConfig;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class WinFlowController : AWinFlowController
	{
		[SerializeField]
		private GameObject x2CoinButton;

		protected override void OnEnable()
		{
		}

		public override int GetWinCoinAmount()
		{
			return 0;
		}

		public override bool IsMonetizeLevel()
		{
			return false;
		}

		public override void ShowContinueAd(Action onClosed)
		{
		}

		public override void CompleteContinueMonetize()
		{
		}

		public override void GoHome()
		{
		}

		public override void TryShowNoAdsOffer()
		{
		}

		protected virtual int GetGateLevel()
		{
			return 0;
		}

		protected virtual WinFlowConfig GetWinFlowConfig()
		{
			return null;
		}

		protected virtual bool IsNoAdsOwned()
		{
			return false;
		}

		protected virtual void ShowInter(Action onClosed)
		{
		}
	}
}
