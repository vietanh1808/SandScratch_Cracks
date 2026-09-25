using System;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class ARewardFlyService : JBase
	{
		public abstract bool IsHolding { get; }

		public abstract bool Fly(RewardKind kind, Vector3 fromWorldPos, Action onDone);

		public abstract void PushHold();

		public abstract void PopHold();
	}
}
