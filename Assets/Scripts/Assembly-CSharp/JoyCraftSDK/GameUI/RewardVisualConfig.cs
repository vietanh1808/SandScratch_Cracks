using System;
using System.Collections.Generic;
using JoyCraftSDK.IAP;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "RewardVisualConfig", menuName = "GameSDK/RewardVisualConfig")]
	public class RewardVisualConfig : ARewardVisualConfig
	{
		[Serializable]
		public struct RewardVisualEntry
		{
			public RewardKind kind;

			public Sprite icon;

			public RewardFlyEffect flyEffectOverride;
		}

		[SerializeField]
		private List<RewardVisualEntry> entries;

		[SerializeField]
		private RewardFlyEffect defaultFlyEffect;

		[SerializeField]
		private List<RewardKind> allBoosterDisplayKinds;

		public override IReadOnlyList<RewardKind> AllBoosterDisplayKinds => null;

		public override Sprite GetIcon(RewardKind kind)
		{
			return null;
		}

		public override RewardFlyEffect GetFlyEffectPrefab(RewardKind kind)
		{
			return null;
		}
	}
}
