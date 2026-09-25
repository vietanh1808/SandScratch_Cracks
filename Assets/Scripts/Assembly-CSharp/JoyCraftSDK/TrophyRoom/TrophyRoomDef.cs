using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.TrophyRoom
{
	[Serializable]
	public class TrophyRoomDef
	{
		[Tooltip("Khoá bền vững — TUYỆT ĐỐI KHÔNG đánh số lại sau khi ship (lệch mapping phòng hiện hành của người chơi).")]
		[SerializeField]
		private int id;

		[SerializeField]
		private string displayName;

		[Tooltip("Layout Addressable của phòng — nền + vị trí/kích thước/layer từng item (TrophyRoomLayout), render vào root prefab dùng chung.")]
		[SerializeField]
		private AssetReferenceT<TrophyRoomLayout> roomLayout;

		[Tooltip("Item mua TUẦN TỰ trong phòng này — index 0 mua trước. id mỗi item PHẢI duy nhất TRÊN TOÀN BỘ config (xuyên mọi phòng).")]
		[SerializeField]
		private List<TrophyItemDef> trophyItemDefs;

		[Tooltip("Phần thưởng cấp 1 LẦN khi phòng này HOÀN THÀNH (mua hết mọi item trong phòng).")]
		[SerializeField]
		private List<TrophyRoomReward> rewards;

		public int Id => 0;

		public string DisplayName => null;

		public AssetReferenceT<TrophyRoomLayout> RoomLayout => null;

		public IReadOnlyList<TrophyItemDef> Items => null;

		public IReadOnlyList<TrophyRoomReward> Rewards => null;

		public bool ContainsItem(int itemId)
		{
			return false;
		}

		public TrophyItemDef GetItem(int itemId)
		{
			return null;
		}
	}
}
