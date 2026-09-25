using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.LiveEvent
{
	[Serializable]
	public class LiveEventMilestoneRow
	{
		private const string Group_Slots = "Slots";

		[Tooltip("Bậc trên track — hàng render tăng dần theo số này (KHÔNG theo thứ tự trong list). Phải > 0 và không trùng hàng khác.")]
		[SerializeField]
		private int tier;

		[Tooltip("GIÁ RIÊNG của bậc: cần THÊM bao nhiêu key kể từ lúc bậc trước mở. Đây là con số người chơi thấy trong ô mốc, và mở xong bậc là thanh tiến độ reset về 0. Phải > 0. Ngưỡng mở thực tế do thang tự CỘNG DỒN. Sửa bậc nào chỉ đổi giá bậc đó — bậc sau chỉ dời thời điểm mở.")]
		[FormerlySerializedAs("unlockCost")]
		[SerializeField]
		private int stepCost;

		[Tooltip("Ô cột FREE của bậc này. Để milestoneId = 0 nghĩa là bậc KHÔNG có mốc free (hợp lệ).")]
		[SerializeField]
		private LiveEventMilestoneEntry freeEntry;

		[Tooltip("Ô cột PREMIUM của bậc này. Để milestoneId = 0 nghĩa là bậc KHÔNG có mốc premium (hợp lệ).")]
		[SerializeField]
		private LiveEventMilestoneEntry premiumEntry;

		public int Tier => 0;

		public int StepCost => 0;

		public LiveEventMilestoneEntry FreeEntry => null;

		public LiveEventMilestoneEntry PremiumEntry => null;

		public string RowLabel => null;

		public LiveEventMilestoneRow()
		{
		}

		public LiveEventMilestoneRow(int tier)
		{
		}

		public bool ApplySlotIdentity()
		{
			return false;
		}

		public bool TryFillSlot(LiveEventMilestoneEntry entry)
		{
			return false;
		}

		private static string DescribeSlot(LiveEventMilestoneEntry entry)
		{
			return null;
		}
	}
}
