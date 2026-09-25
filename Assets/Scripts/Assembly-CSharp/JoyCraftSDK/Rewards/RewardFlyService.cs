using System;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.IAP;
using UnityEngine;

namespace JoyCraftSDK.Rewards
{
	public class RewardFlyService : ARewardFlyService
	{
		private int _holdCount;

		private ARewardVisualConfig rewardVisualConfig => null;

		public override bool IsHolding => false;

		public override bool Fly(RewardKind kind, Vector3 fromWorldPos, Action onDone)
		{
			return false;
		}

		public override void PushHold()
		{
		}

		public override void PopHold()
		{
		}
	}
}
