using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBattlePassData : JSaveData
	{
		public const int MaxVersion_SavedBattlePassData = 2;

		[SerializeField]
		private SavedWalletIntData savedWalletIntData;

		[SerializeField]
		private SavedTrackData savedTrackData;

		[SerializeField]
		private SavedAdGateData savedAdGateData;

		public SavedWalletIntData SavedWalletIntData => null;

		public SavedTrackData SavedTrackData => null;

		public SavedAdGateData SavedAdGateData => null;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override bool UpdateVersionIncremental(int currentVersion)
		{
			return false;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}
	}
}
