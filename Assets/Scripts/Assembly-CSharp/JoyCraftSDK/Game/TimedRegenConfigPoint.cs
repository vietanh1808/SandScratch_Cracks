using System;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class TimedRegenConfigPoint
	{
		[Tooltip("Loại resource được hồi/reset theo thời gian (heart, energy, daily ads...). Key để TimedRegenManager tra config.")]
		public RegenResourceType type;

		[Tooltip("Kiểu thời gian:\n- Cooldown: hồi dần +1 mỗi chu kỳ, neo vào thời điểm dừng cuối.\n- TimelyReset: reset đầy 1 phát tại mốc 00:00 UTC, lặp lại mỗi N ngày.")]
		[ColoredEnumToggleButtons(0.45f, 0.9f, 0.45f)]
		public RegenKind kind;

		[Tooltip("Trần tối đa khi hồi tự nhiên. Cả Cooldown và TimelyReset đều dùng.")]
		public int maxCount;

		[Tooltip("Count khi point mới (chưa có save). Muốn bắt đầu đầy -> = maxCount. Default 0. Chỉ áp dụng cho Cooldown.")]
		public int initialCount;

		[Tooltip("Chu kỳ hồi 1 đơn vị (giây).")]
		public int regenSeconds;

		[Tooltip("Count sau reset (thường = maxCount).")]
		public int resetValue;

		[Tooltip("Khoảng thời gian giữa 2 lần reset, đơn vị NGÀY. 1 = reset mỗi ngày. <=0 -> coi như 1.")]
		public int resetIntervalDays;

		[Tooltip("Trần cho grant thủ công.\n- -1: VÔ HẠN (vượt maxCount không giới hạn).\n- 0 hoặc <maxCount: = maxCount.")]
		public int hardMaxCount;
	}
}
