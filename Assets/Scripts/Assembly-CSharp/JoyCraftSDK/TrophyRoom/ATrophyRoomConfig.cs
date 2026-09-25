using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.TrophyRoom
{
	public abstract class ATrophyRoomConfig : JScriptableObject
	{
		private const string Group_Gate = "Gate";

		private const string Group_Rooms = "Rooms — thứ tự = thứ tự mở phòng";

		[Tooltip("Feature-gate: Trophy Room chỉ mở khi Level người chơi >= giá trị này. 0 = mở ngay từ đầu.")]
		[SerializeField]
		private int unlockAtLevel;

		[Tooltip("Số Star nhận được mỗi level Normal hoàn thành.")]
		[SerializeField]
		private int starsPerLevelNormal;

		[Tooltip("Số Star nhận được mỗi level Hard hoàn thành.")]
		[SerializeField]
		private int starsPerLevelHard;

		[Tooltip("Số Star nhận được mỗi level VeryHard hoàn thành.")]
		[SerializeField]
		private int starsPerLevelVeryHard;

		[Tooltip("Danh sách phòng TUẦN TỰ — phòng đầu tiên mở trước. id mỗi phòng PHẢI duy nhất; id item PHẢI duy nhất TRÊN TOÀN BỘ các phòng.")]
		[SerializeField]
		private List<TrophyRoomDef> rooms;

		public int UnlockAtLevel => 0;

		public IReadOnlyList<TrophyRoomDef> Rooms => null;

		public bool IsUnlockedAtLevel(int level)
		{
			return false;
		}

		public int GetStarsForDifficulty(ReleaseDifficulty difficulty)
		{
			return 0;
		}

		public TrophyRoomDef GetRoom(int roomId)
		{
			return null;
		}

		public TrophyItemDef GetItem(int id)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
