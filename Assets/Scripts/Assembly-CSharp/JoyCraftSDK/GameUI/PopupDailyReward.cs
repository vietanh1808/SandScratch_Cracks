using JoyCraftSDK.DailyReward;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupDailyReward : JUIPanel
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private DRItem[] dayItems;

		[SerializeField]
		private BtnClaimDailyReward btnClaim;

		[SerializeField]
		private TextMeshProUGUI timerText;

		[SerializeField]
		private ARewardVisualConfig rewardVisualConfig;

		private float timerAccumulator;

		private bool isBusy;

		private int lastKnownSlotIndex;

		private ADailyRewardManager _dailyRewardManager => null;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void Init()
		{
		}

		protected override void RegisterEvent()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		public override void OnDisappear()
		{
		}

		public void ClaimToday()
		{
		}

		private void ClaimFree(int slotIndex)
		{
		}

		private void OnDayItemClicked(int slotIndex)
		{
		}

		private void PlayClaimFeedbackThenShowReward(int slotIndex)
		{
		}

		private void ClaimMissedWithAd(int slotIndex)
		{
		}

		private void OnAdRewarded(int slotIndex)
		{
		}

		private void OnRewardedFailed(ref AEventManager.OnShowRewardedFailed eventData)
		{
		}

		private void Refresh()
		{
		}

		private void TickTimer(ref AEventManager.OnUpdate eventData)
		{
		}

		private void UpdateTimerText()
		{
		}

		private void ShowRewardPopup(int slotIndex)
		{
		}
	}
}
