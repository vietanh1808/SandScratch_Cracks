using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game.SaveData
{
	[Serializable]
	public class SavedBoosterDataPoint
	{
		[SerializeField]
		public BoosterType type;

		[SerializeField]
		public int quantity;

		[SerializeField]
		public bool FTUEIsShowed;

		[SerializeField]
		public bool unlockGiftGranted;
	}
}
