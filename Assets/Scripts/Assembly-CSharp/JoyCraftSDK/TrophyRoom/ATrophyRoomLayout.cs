using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.TrophyRoom
{
	public abstract class ATrophyRoomLayout : JScriptableObject
	{
		private const string Group_Room = "Room";

		private const string Group_Items = "Items";

		[Tooltip("Khoá bền vững — phải khớp TrophyRoomDef.Id trong TrophyRoomConfig.")]
		[SerializeField]
		private int roomId;

		[SerializeField]
		private Sprite background;

		[Tooltip("Kích thước tham chiếu (px) mà position/size của item trong danh sách itemLayouts được tính theo.")]
		[SerializeField]
		private Vector2 referenceResolution;

		[SerializeField]
		private List<TrophyRoomItemLayout> itemLayouts;

		public int RoomId => 0;

		public Sprite Background => null;

		public Vector2 ReferenceResolution => default;

		public IReadOnlyList<TrophyRoomItemLayout> Items => null;

		public bool ContainsItem(int itemId)
		{
			return false;
		}

		public TrophyRoomItemLayout GetItem(int itemId)
		{
			return null;
		}
	}
}
