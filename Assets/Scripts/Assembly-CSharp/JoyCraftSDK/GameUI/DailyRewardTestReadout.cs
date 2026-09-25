using JoyCraftSDK.DailyReward;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class DailyRewardTestReadout : JMonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI readoutText;

		private float _accumulator;

		private ADailyRewardManager _dailyRewardManager => null;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void TickReadout(ref AEventManager.OnUpdate eventData)
		{
		}

		private void RefreshNow()
		{
		}
	}
}
