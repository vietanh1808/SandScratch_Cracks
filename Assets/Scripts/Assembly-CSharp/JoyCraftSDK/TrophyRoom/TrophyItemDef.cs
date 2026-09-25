using System;
using UnityEngine;

namespace JoyCraftSDK.TrophyRoom
{
	[Serializable]
	public class TrophyItemDef
	{
		[Tooltip("Khoá bền vững — Save chỉ lưu id này. TUYỆT ĐỐI KHÔNG đánh số lại sau khi ship (lệch mapping item đã sở hữu của người chơi).")]
		[SerializeField]
		private int id;

		[SerializeField]
		private string displayName;

		[SerializeField]
		private int starCost;

		[Tooltip("Icon shop (lưới mua) — placeholder, được phép null lúc chưa có art. Art ĐẶT trong phòng nằm ở roomLayout, KHÔNG phải field này.")]
		[SerializeField]
		private Sprite sprite;

		public int Id => 0;

		public string DisplayName => null;

		public int StarCost => 0;

		public Sprite Sprite => null;
	}
}
