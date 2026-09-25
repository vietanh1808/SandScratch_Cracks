using JoyCraftSDK.LiveEvent;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class ScreenBattlePass : JUIPanel
	{
		private const string Group_Track = "Track";

		private const string Group_Header = "Header + Premium";

		[SerializeField]
		private BattlePassTrackScroll trackScroll;

		[Tooltip("Tiến độ MỞ tier kế dạng '{key dư}/{key cần}' — vd '0/3'. Cạnh icon key ở header.")]
		[SerializeField]
		private TextMeshProUGUI keyProgressText;

		[Tooltip("Bar tiến độ MỞ tier kế, đi CẶP với keyProgressText. Image PHẢI Type=Filled (Simple thì fillAmount vô hiệu, bar đứng im). Bỏ trống = không hiện.")]
		[SerializeField]
		private Image keyFillImage;

		[Tooltip("Số BẬC đang mở tới — phải khớp số hiện giữa hàng trên track.")]
		[SerializeField]
		private TextMeshProUGUI nextTierText;

		[Tooltip("DEV-ONLY (CTO chốt 2026-08-10) — 'Tổng mùa: N' = key tích lũy lái tiến độ tier. Bỏ trống = không hiện.")]
		[SerializeField]
		private TextMeshProUGUI keyEarnedText;

		[Tooltip("DEV-ONLY — 'Ví: N' = key còn tiêu được để nhận thưởng (KHÁC tử số header). Bỏ trống = không hiện.")]
		[SerializeField]
		private TextMeshProUGUI keyBalanceText;

		[SerializeField]
		private GameObject premiumOfferRoot;

		private const float KeyFillVisualMax = 0.8f;

		private ABattlePassManager _battlePassManager => null;

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

		private void RefreshAll()
		{
		}

		private void OnCurrencyChanged(ref AEventManager.OnLiveEventCurrencyChanged eventData)
		{
		}

		private void OnMilestoneClaimed(ref AEventManager.OnLiveEventMilestoneClaimed eventData)
		{
		}

		private void OnPremiumUnlocked(ref AEventManager.OnLiveEventPremiumUnlocked eventData)
		{
		}

		private void SetText(TextMeshProUGUI target, string content)
		{
		}

		private void SetFill(Image target, float normalized)
		{
		}

		private new void SetActive(GameObject target, bool isActive)
		{
		}
	}
}
