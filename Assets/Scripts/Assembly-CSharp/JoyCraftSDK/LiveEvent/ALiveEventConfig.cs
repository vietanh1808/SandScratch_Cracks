using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ALiveEventConfig : JScriptableObject
	{
		private const string Group_Event = "Event";

		private const string Group_Track = "Track thưởng — 1 phần tử = 1 BẬC (ô FREE trái · ô PREMIUM phải)";

		[Tooltip("Id event — vào payload bus, phân biệt event; KHÔNG đổi sau ship.")]
		[SerializeField]
		private string eventId;

		[SerializeField]
		private TrackMode trackMode;

		[Tooltip("Feature-gate: event chỉ mở khi Level người chơi ≥ giá trị này. 0 = không gate (mở ngay).")]
		[SerializeField]
		private int unlockAtLevel;

		[Tooltip("Teaser (chỉ hiển thị): từ Level này icon entry HIỆN ở trạng thái KHOÁ tới khi đạt unlockAtLevel — CHƯA earn/claim. 0 = tắt teaser (ẩn hẳn tới lúc unlock). Nên đặt ≤ unlockAtLevel.")]
		[SerializeField]
		private int previewAtLevel;

		[Tooltip("Mỗi hàng tự mang số tier; track render theo tier TĂNG DẦN, không theo thứ tự trong list. milestoneId phải STABLE + unique (giá trị ghi vào save khi claim).")]
		[SerializeField]
		private List<LiveEventMilestoneRow> milestoneRows;

		[HideInInspector]
		[SerializeField]
		private List<LiveEventMilestoneEntry> milestoneEntries;

		public string EventId => null;

		public TrackMode TrackMode => TrackMode.Spend;

		public int UnlockAtLevel => 0;

		public int PreviewAtLevel => 0;

		public IReadOnlyList<LiveEventMilestoneEntry> MilestoneEntries => null;

		public bool IsUnlockedAtLevel(int level)
		{
			return false;
		}

		public bool IsInPreviewWindow(int level)
		{
			return false;
		}

		public IReadOnlyList<LiveEventMilestoneTier> GetTiers()
		{
			return null;
		}

		private bool EnsureRowsBuilt()
		{
			return false;
		}
	}
}
