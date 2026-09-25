using System;
using System.Collections.Generic;
using JoyCraftSDK.LiveEvent;
using UnityEngine;

namespace JoyCraftSDK.DailyReward
{
	[Serializable]
	public class DailyRewardSlot
	{
		[Tooltip("Phần thưởng của ngày này — 1 ngày trả được NHIỀU thứ (vd 1000 coin + x1 búa). Rỗng = slot hỏng, manager chặn claim fail-loud.")]
		[SerializeField]
		private List<LiveEventReward> rewards;

		public IReadOnlyList<LiveEventReward> Rewards => null;

		public bool HasAnyReward()
		{
			return false;
		}
	}
}
