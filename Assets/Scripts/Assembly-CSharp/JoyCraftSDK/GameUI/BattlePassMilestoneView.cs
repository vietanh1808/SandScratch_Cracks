using System.Collections.Generic;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassMilestoneView : JMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		private const string Group_Refs = "References";

		private const string Group_States = "State Roots";

		private const string Group_MultiReward = "Multi Reward";

		private const string Group_Message = "Message Popup";

		[Tooltip("Optional — số thứ tự mốc dạng 'MỐC #id', TÁCH khỏi cost (§4b-2). Bỏ trống nếu hàng đã hiện số bậc.")]
		[SerializeField]
		private TextMeshProUGUI milestoneIdText;

		[SerializeField]
		private TextMeshProUGUI gateValueText;

		[SerializeField]
		private TextMeshProUGUI rewardText;

		[SerializeField]
		private BtnClaimMilestone claimButton;

		[Tooltip("Nút xem ad đặt CHỒNG vị trí nút claim — chỉ hiện ở state AdGated (mốc free thấp nhất khi ad-gate bật). Bỏ trống = ô gated trông như Locked.")]
		[SerializeField]
		private BtnWatchAdForBattlePass watchAdButton;

		[SerializeField]
		private GameObject premiumBadge;

		[SerializeField]
		private GameObject claimedMark;

		[SerializeField]
		private GameObject lockedMask;

		[Tooltip("Root bật/tắt khi hàng KHÔNG có mốc ở side này. Bỏ trống = tắt chính GameObject của view.")]
		[SerializeField]
		private GameObject contentRoot;

		[Tooltip("Icon TĨNH của ô — node 'Icon Reward' (KHÔNG phải 'IconReward' template trong RewardContainer). Sprite bơm runtime mỗi SetEntry; thiếu icon = ẩn node.")]
		[SerializeField]
		private Image rewardIcon;

		[Tooltip("Node 'Popupreward' — bảng icon của mốc NHIỀU reward. Bỏ trống = ô giữ text gộp (fallback).")]
		[SerializeField]
		private GameObject rewardPopupRoot;

		[Tooltip("'RewardContainer' (HorizontalLayoutGroup) — cha của các icon clone.")]
		[SerializeField]
		private Transform rewardIconContainer;

		[Tooltip("'IconReward' — TEMPLATE clone theo từng reward. Code tự tắt bản gốc.")]
		[SerializeField]
		private Image rewardIconTemplate;

		[Tooltip("Nguồn icon kind→sprite (RewardVisualConfig.asset, dùng chung với PopupReward).")]
		[SerializeField]
		private ARewardVisualConfig rewardVisualConfig;

		[Tooltip("'TailDown' — đuôi chỉ XUỐNG, hiện khi bảng bung LÊN trên ô. Bỏ trống = bảng không có đuôi.")]
		[SerializeField]
		private RectTransform tailDown;

		[Tooltip("'TailUp' — đuôi chỉ LÊN, hiện khi bảng bung XUỐNG dưới ô.")]
		[SerializeField]
		private RectTransform tailUp;

		[Tooltip("Node 'PopupMessage' — bảng thông báo (mốc chưa nhận được: thiếu key / chưa mua pass). Bỏ trống = bấm ô chưa nhận không có gì.")]
		[SerializeField]
		private GameObject messagePopupRoot;

		[Tooltip("'BgDown' — nền sprite frame4 (đuôi vẽ liền đáy-trái), hiện khi bảng bung LÊN.")]
		[SerializeField]
		private RectTransform messageBgDown;

		[Tooltip("'BgUp' — cùng sprite frame4, lật trục Y (đuôi chỉ LÊN), hiện khi bảng bung XUỐNG.")]
		[SerializeField]
		private RectTransform messageBgUp;

		[Tooltip("Khối chữ — SIBLING của 2 Bg, KHÔNG đặt trong Bg (Bg lật scale thì chữ lật theo). Code chỉ đảo dấu Y theo hướng bung; nội dung author trong prefab.")]
		[SerializeField]
		private RectTransform messageContent;

		private const float PopupGap = 8f;

		private const float ViewportMargin = 12f;

		private const float TailCornerGuard = 28f;

		private const float MessageTailPivotX = 0.193f;

		private const float MessagePopupGap = -2f;

		private LiveEventMilestoneEntry milestoneEntry;

		private BattlePassRewardPreviewRouter previewRouter;

		private bool hasRewardPreview;

		private readonly List<Image> spawnedRewardIcons;

		private RectTransform cachedViewport;

		private bool viewportResolved;

		private ABattlePassManager _battlePassManager => null;

		public int MilestoneId => 0;

		public void SetEntry(LiveEventMilestoneEntry entry, BattlePassRewardPreviewRouter router)
		{
		}

		private void FlyClaimedRewards()
		{
		}

		private void ApplyRewardDisplay(LiveEventMilestoneEntry entry)
		{
		}

		private void ApplyStaticIcon(LiveEventMilestoneEntry entry)
		{
		}

		private Sprite ResolveStaticIcon(LiveEventMilestoneEntry entry)
		{
			return null;
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void ShowPopup()
		{
		}

		public void HidePopup()
		{
		}

		private void ShowRewardPreview()
		{
		}

		private void HideRewardPreview()
		{
		}

		private bool CanShowMessage()
		{
			return false;
		}

		private static bool IsMessageState(BattlePassMilestoneState state)
		{
			return false;
		}

		private void BuildRewardIcons(IReadOnlyList<LiveEventReward> rewards)
		{
		}

		private void ApplyIconAmount(Image iconImage, LiveEventReward reward)
		{
		}

		private void ClearRewardIcons()
		{
		}

		private void PositionRewardPopup()
		{
		}

		private bool PlacePopupVertical(RectTransform popupRect, RectTransform viewport, float pivotX, float gap)
		{
			return false;
		}

		private bool ShouldOpenUp(RectTransform cellRect, RectTransform viewport)
		{
			return false;
		}

		private void ClampPopupHorizontal(RectTransform popupRect, RectTransform viewport, bool openUp)
		{
		}

		private void ShowMessagePopup()
		{
		}

		private void MirrorMessagePopupIfOverflow(RectTransform popupRect, RectTransform viewport)
		{
		}

		private void SetMessageMirror(RectTransform popupRect, bool mirrored)
		{
		}

		private void HideMessagePopup()
		{
		}

		private RectTransform ResolveViewport()
		{
			return null;
		}

		private static string BuildRewardsText(LiveEventMilestoneEntry entry)
		{
			return null;
		}

		private static string ToSingleRewardLabel(LiveEventReward reward)
		{
			return null;
		}

		public void Refresh()
		{
		}

		private BattlePassMilestoneState ResolveState()
		{
			return BattlePassMilestoneState.Locked;
		}

		private void SetSideActive(bool isActive)
		{
		}

		private new void SetActive(GameObject target, bool isActive)
		{
		}
	}
}
