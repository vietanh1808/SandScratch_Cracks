using System;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public class BtnClaimMilestone : JButton
	{
		private int milestoneId;

		private bool isBound;

		private Action onClaimSucceeded;

		private ABattlePassManager _battlePassManager => null;

		public void Bind(int id, Action onClaimSucceededCallback)
		{
		}

		protected override void OnClick()
		{
		}
	}
}
