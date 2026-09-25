using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedWalletIntData : JSaveData, ISeasonResettable
	{
		public const int MaxVersion_SavedWalletIntData = 1;

		[SerializeField]
		private int earned;

		public int Earned => 0;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public void AddEarned(int amount)
		{
		}

		public void ResetSeason()
		{
		}
	}
}
