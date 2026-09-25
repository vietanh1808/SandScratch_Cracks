using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class ScreenLose : JUIPanel
	{
		[Serializable]
		private enum LoseSubView
		{
			Offer = 0,
			LoseWarning = 1
		}

		[Serializable]
		private struct BundleCard
		{
			[SerializeField]
			private GameObject cardRoot;

			[SerializeField]
			private BtnBuyBundle buyButton;

			public GameObject CardRoot => null;

			public BtnBuyBundle BuyButton => null;
		}

		private const float SwapDuration = 0.25f;

		private const float PeekFadeDuration = 0.2f;

		private const string Group_SubView = "Sub-View";

		[SerializeField]
		private RectTransform offerView;

		[SerializeField]
		private RectTransform loseWarningView;

		[SerializeField]
		private RawImage videoPlayOn;

		[SerializeField]
		private CanvasGroup shellGroup;

		[SerializeField]
		private GameObject warningLifeLine;

		[SerializeField]
		private AButton closeButton;

		private LoseSubView _subView;

		private bool _confirmConsumed;

		private const string Group_Bundle = "Bundle Offer";

		[SerializeField]
		private GameObject bundleOffer;

		[SerializeField]
		private BundleSnapScroll bundleScroll;

		[SerializeField]
		private List<BundleCard> bundleCards;

		[SerializeField]
		private LoseBundleCard loseCardPrefab;

		[SerializeField]
		private RectTransform loseCardParent;

		private readonly List<LoseBundleCard> spawnedLoseCards;

		[SerializeField]
		private TextMeshProUGUI playOnPrice;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void OnAppearInternal()
		{
		}

		public override void OnDisappear()
		{
		}

		public void OnClickX()
		{
		}

		private void ShowLoseWarning()
		{
		}

		private void ConfirmFail()
		{
		}

		public void PeekBoard(bool peeking)
		{
		}

		private void ResetLoseState()
		{
		}

		private void SetXInteractable(bool interactable)
		{
		}

		private float GetViewWidth()
		{
			return 0f;
		}

		private void RefreshBundleOffer()
		{
		}

		private bool RefreshLoseCards()
		{
			return false;
		}

		protected override void RegisterEvent()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		private void OnPremiumUnlocked(ref AEventManager.OnLiveEventPremiumUnlocked eventData)
		{
		}

		protected override void Init()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
