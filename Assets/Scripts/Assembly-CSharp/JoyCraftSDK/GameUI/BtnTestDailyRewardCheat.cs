using JoyCraftSDK.DailyReward;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnTestDailyRewardCheat : JButton
	{
		[SerializeField]
		private DailyRewardCheatKind cheatKind;

		[Tooltip("Chỉ dùng cho kind ShiftDays/ForceTimeRollback — số ngày dời/rollback.")]
		[SerializeField]
		private int dayCount;

		private ADailyRewardManager _dailyRewardManager => null;

		protected override void OnClick()
		{
		}
	}
}
