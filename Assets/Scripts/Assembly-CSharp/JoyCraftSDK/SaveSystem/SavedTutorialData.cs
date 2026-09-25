using System;
using System.Collections.Generic;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedTutorialData : JSaveData
	{
		public const int MaxVersion_SavedTutorialData = 1;

		[SerializeField]
		private List<SavedTutorialDataPoint> tutorialDataPoints;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public bool IsCompleted(TutorialType type)
		{
			return false;
		}

		public void SaveData(TutorialType type, bool isCompleted)
		{
		}
	}
}
