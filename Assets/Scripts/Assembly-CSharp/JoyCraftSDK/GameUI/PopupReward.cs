using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupReward : JUIPanel
	{
		private const string Group_References = "References";

		private const string Group_Config = "Config";

		private const int ColumnsPerRow = 3;

		[SerializeField]
		private ARewardVisualConfig _rewardVisualConfig;

		[SerializeField]
		private RewardItemView _rewardItemTemplate;

		[SerializeField]
		private Transform _rewardRowTemplate;

		[SerializeField]
		private Transform _rewardItemContainer;

		[SerializeField]
		private GameObject _claimHideRoot;

		[SerializeField]
		private float _itemPopDuration;

		[SerializeField]
		private float _itemPopStagger;

		[SerializeField]
		private EasingType _itemPopEasing;

		private readonly List<RewardItemView> _spawnedRewardItems;

		private readonly List<Transform> _spawnedRewardRows;

		private Action _onClaimed;

		private bool _isClaiming;

		private int _pendingFlyCount;

		private int _pendingRevealCount;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public void SetRewards(List<RewardDisplayData> rewardDisplayList, Action onClaimed = null)
		{
		}

		public void Claim()
		{
		}

		public override void OnDisappear()
		{
		}

		private void OnItemRevealed()
		{
		}

		private void OnFlyEffectComplete()
		{
		}

		private void FinishClaim()
		{
		}

		private List<RewardDisplayData> ExpandAllBooster(List<RewardDisplayData> source)
		{
			return null;
		}

		private void ClearItems()
		{
		}
	}
}
