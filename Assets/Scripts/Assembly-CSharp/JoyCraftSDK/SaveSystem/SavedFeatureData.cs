using System;
using System.Collections.Generic;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedFeatureData : JSaveData
	{
		public const int MaxVersion_SavedFeatureData = 1;

		[SerializeField]
		private List<SavedFeatureDataPoint> featureDataPoints;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public void FinishFTUE(GameFeatureType type)
		{
		}

		public bool IsFTUEShowed(GameFeatureType type)
		{
			return false;
		}
	}
}
