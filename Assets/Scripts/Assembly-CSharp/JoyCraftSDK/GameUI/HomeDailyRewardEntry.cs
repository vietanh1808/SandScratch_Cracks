using JoyCraftSDK.DailyReward;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HomeDailyRewardEntry : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		[SerializeField]
		private GameObject dailyRewardIcon;

		private ADailyRewardManager _dailyRewardManager => null;

		protected override void OnEnable()
		{
		}

		private void Refresh()
		{
		}
	}
}
