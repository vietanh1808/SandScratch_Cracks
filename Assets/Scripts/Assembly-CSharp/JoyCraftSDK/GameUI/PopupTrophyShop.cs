using System.Collections.Generic;
using JoyCraftSDK.TrophyRoom;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupTrophyShop : JUIPanel
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private TextMeshProUGUI starText;

		[SerializeField]
		private TrophyShopScroll itemScroll;

		[SerializeField]
		private GameObject rewardPreviewRoot;

		[SerializeField]
		private Transform rewardPreviewContainer;

		[SerializeField]
		private RewardItemView rewardPreviewTemplate;

		[SerializeField]
		private ARewardVisualConfig rewardVisualConfig;

		[SerializeField]
		private TMP_Text earnMoreHintText;

		private readonly List<RewardItemView> _spawnedRewardPreviewItems;

		private ATrophyRoomManager _trophyRoomManager => null;

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

		private void OnItemPurchased(ref AEventManager.OnTrophyItemPurchased eventData)
		{
		}

		public void BuyItem(int itemId)
		{
		}

		private void Refresh()
		{
		}

		private void RefreshRewardPreview(TrophyRoomDef currentRoom)
		{
		}

		private void ClearRewardPreview()
		{
		}

		private void RefreshEarnMoreHint(TrophyRoomDef currentRoom)
		{
		}

		private bool HasAffordableUnownedItem(TrophyRoomDef room)
		{
			return false;
		}
	}
}
