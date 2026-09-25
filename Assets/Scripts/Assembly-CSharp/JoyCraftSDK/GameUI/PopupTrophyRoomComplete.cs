using System;
using System.Collections.Generic;
using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupTrophyRoomComplete : JUIPanel
	{
		private const string Group_References = "References";

		private const string Group_Config = "Config";

		[SerializeField]
		private Animator winAnim;

		[SerializeField]
		private RectTransform[] rects;

		[SerializeField]
		private GameObject[] vfx;

		[SerializeField]
		private TMP_Text roomNameText;

		[SerializeField]
		private ARewardVisualConfig rewardVisualConfig;

		[SerializeField]
		private RewardItemView rewardItemTemplate;

		[SerializeField]
		private Transform rewardItemContainer;

		[SerializeField]
		private GameObject claimHideRoot;

		[SerializeField]
		private float delayWinAnim;

		[SerializeField]
		private float itemPopDuration;

		[SerializeField]
		private float itemPopStagger;

		[SerializeField]
		private EasingType itemPopEasing;

		private readonly List<RewardItemView> _spawnedRewardItems;

		private Action _onClaimed;

		private bool _isClaiming;

		private int _pendingFlyCount;

		private static readonly int AnimIdleDisappear;

		private static readonly int AnimAppear;

		private ATrophyRoomManager _trophyRoomManager => null;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public void SetData(TrophyRoomDef room, IReadOnlyList<TrophyRoomReward> rewards, Action onClaimed)
		{
		}

		public void ShowAnim()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Claim()
		{
		}

		public override void OnDisappear()
		{
		}

		private void OnFlyEffectComplete()
		{
		}

		private void FinishClaim()
		{
		}

		private void ClearItems()
		{
		}
	}
}
