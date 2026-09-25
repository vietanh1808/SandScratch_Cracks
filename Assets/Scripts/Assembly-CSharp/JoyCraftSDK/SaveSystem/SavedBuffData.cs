using System;
using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBuffData : JSaveData
	{
		public const int MaxVersion_SavedBuffData = 1;

		[SerializeField]
		private List<SavedBuffPoint> buffPoints;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public IReadOnlyList<SavedBuffPoint> GetPoints()
		{
			return null;
		}

		public SavedBuffPoint GetOrCreatePoint(BuffType type)
		{
			return null;
		}

		public void RemovePoint(BuffType type)
		{
		}
	}
}
