using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "IngameRopeData", menuName = "GameSDK/DataPreset/IngameRopeData")]
	public class IngameRopeData : JScriptableObject
	{
		[Serializable]
		public struct Record
		{
			public GameObjectColor gameObjectColor;

			public Color color;

			public Material hookColorMat;

			public Material ropeMat;
		}

		public Record[] records;
	}
}
