using System;
using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedRegenData : JSaveData
	{
		public const int MaxVersion_SavedRegenData = 1;

		[SerializeField]
		private List<SavedRegenPoint> regenPoints;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public SavedRegenPoint GetOrCreatePoint(RegenResourceType type)
		{
			return null;
		}

		public bool HasPoint(RegenResourceType type)
		{
			return false;
		}
	}
}
