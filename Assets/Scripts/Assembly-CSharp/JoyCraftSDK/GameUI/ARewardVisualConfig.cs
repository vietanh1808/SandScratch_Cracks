using System.Collections.Generic;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class ARewardVisualConfig : JScriptableObject
	{
		public abstract IReadOnlyList<RewardKind> AllBoosterDisplayKinds { get; }

		public abstract Sprite GetIcon(RewardKind kind);

		public abstract RewardFlyEffect GetFlyEffectPrefab(RewardKind kind);
	}
}
