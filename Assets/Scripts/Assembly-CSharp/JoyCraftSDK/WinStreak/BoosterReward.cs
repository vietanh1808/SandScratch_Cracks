using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.WinStreak
{
	[Serializable]
	public class BoosterReward
	{
		[Tooltip("Loại booster được tặng tạm.")]
		[SerializeField]
		private BoosterType boosterType;

		[Tooltip("Số charge tạm được tặng.")]
		[SerializeField]
		private int count;

		public BoosterType BoosterType => BoosterType.None;

		public int Count => 0;

		public BoosterReward()
		{
		}

		public BoosterReward(BoosterType boosterType, int count)
		{
		}
	}
}
