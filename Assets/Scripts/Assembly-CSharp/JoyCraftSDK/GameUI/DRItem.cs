using System;
using System.Collections.Generic;
using DG.Tweening;
using JoyCraftSDK.DailyReward;
using JoyCraftSDK.IAP;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class DRItem : JButton
	{
		[Serializable]
		public class RewardView
		{
			public Image icon;

			public TextMeshProUGUI amountText;
		}

		private const string Group_Sprites = "Sprites";

		private const string Group_Refs = "References";

		private const string Group_Optional = "Optional";

		[SerializeField]
		private Image faceImage;

		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private Sprite faceOpenSprite;

		[SerializeField]
		private Sprite frameOpenSprite;

		[SerializeField]
		private Sprite faceNormalSprite;

		[SerializeField]
		private Sprite frameNormalSprite;

		[SerializeField]
		private TextMeshProUGUI dayText;

		[SerializeField]
		private RewardView[] rewardViews;

		[Tooltip("Optional — để trống nếu prefab chưa dựng.")]
		[SerializeField]
		private GameObject claimedTick;

		[SerializeField]
		private GameObject adIcon;

		[SerializeField]
		private GameObject dimOverlay;

		[SerializeField]
		private GameObject lockIcon;

		private const float PulseToScale = 1.05f;

		private const float PulseLegDuration = 0.4f;

		private Tween statePulseTween;

		private Transform statePulseTarget;

		private Tween claimFeedbackTween;

		private CanvasGroup canvasGroup;

		private readonly List<LiveEventReward> boundRewards;

		private Action<int> onClicked;

		public int SlotIndex { get; private set; }

		public DailyRewardSlotState State { get; private set; }

		public IReadOnlyList<RewardView> RewardViews => null;

		public IReadOnlyList<LiveEventReward> BoundRewards => null;

		public void Bind(int slotIndex, DailyRewardSlotState state, DailyRewardSlot slot, ARewardVisualConfig visualConfig, Action<int> onClickedCallback)
		{
		}

		private static bool IsClickableState(DailyRewardSlotState state)
		{
			return false;
		}

		private void SetPointerEnabled(bool enabled)
		{
		}

		private void RefreshStatePulse(DailyRewardSlotState state)
		{
		}

		private void StartStatePulse(Transform target)
		{
		}

		private void KillStatePulse()
		{
		}

		public void PlayClaimFeedback(Action onComplete)
		{
		}

		private void KillClaimFeedback()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void BindRewards(DailyRewardSlot slot, ARewardVisualConfig visualConfig)
		{
		}

		private static string ToLabel(RewardKind kind, int amount)
		{
			return null;
		}

		protected override void OnClick()
		{
		}
	}
}
