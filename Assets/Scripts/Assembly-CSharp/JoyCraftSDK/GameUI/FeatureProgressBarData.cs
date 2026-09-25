using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "FeatureProgressBarData", menuName = "GameSDK/FeatureProgressBarData")]
	public class FeatureProgressBarData : JScriptableObject
	{
		[Serializable]
		public struct Record
		{
			public GameFeatureType featureType;

			public int unlockAtLevel;

			public Sprite iconSprite;
		}

		public Record[] records;
	}
}
