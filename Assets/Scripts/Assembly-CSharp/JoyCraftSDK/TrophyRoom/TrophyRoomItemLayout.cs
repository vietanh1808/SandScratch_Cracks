using System;
using UnityEngine;

namespace JoyCraftSDK.TrophyRoom
{
	[Serializable]
	public class TrophyRoomItemLayout
	{
		private const string Group_Layout = "Layout";

		[Tooltip("Phải khớp TrophyItemDef.Id trong TrophyRoomConfig (phòng chứa item này).")]
		[SerializeField]
		private int itemId;

		[Tooltip("Art hiển thị TRONG phòng — khác icon shop (TrophyItemDef.Sprite).")]
		[SerializeField]
		private Sprite sprite;

		[Tooltip("anchoredPosition tính từ TÂM phòng, trong không gian referenceResolution (y hướng LÊN).")]
		[SerializeField]
		private Vector2 position;

		[SerializeField]
		private Vector2 size;

		[Tooltip("Thứ tự vẽ — số NHỎ vẽ trước (nằm dưới các item số lớn hơn).")]
		[SerializeField]
		private int layer;

		public int ItemId => 0;

		public Sprite Sprite => null;

		public Vector2 Position => default;

		public Vector2 Size => default;

		public int Layer => 0;
	}
}
