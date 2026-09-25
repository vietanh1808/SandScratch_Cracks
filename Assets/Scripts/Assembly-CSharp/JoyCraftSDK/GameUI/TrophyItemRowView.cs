using System;
using JoyCraftSDK.TrophyRoom;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TrophyItemRowView : JCellView
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI costText;

		[Tooltip("Nút mua CỦA HÀNG này — optional, để trống nếu prefab chưa wire.")]
		[SerializeField]
		private BtnBuyTrophy btnBuy;

		[Tooltip("Optional — để trống nếu prefab chưa dùng.")]
		[SerializeField]
		private GameObject ownedOverlay;

		[Tooltip("KHÔNG còn ý nghĩa từ khi bỏ luật mua tuần tự (mỗi hàng có nút Buy riêng) — LUÔN tắt, giữ field lại phòng prefab cũ còn tham chiếu.")]
		[SerializeField]
		private GameObject lockedOverlay;

		[Tooltip("KHÔNG còn ý nghĩa từ khi bỏ luật mua tuần tự (mỗi hàng có nút Buy riêng) — LUÔN tắt, giữ field lại phòng prefab cũ còn tham chiếu.")]
		[SerializeField]
		private GameObject nextHighlight;

		private int itemId;

		private ATrophyRoomManager _trophyRoomManager => null;

		public void SetData(TrophyItemDef def, Action<int> onBuy)
		{
		}

		public override void RefreshCellView()
		{
		}
	}
}
