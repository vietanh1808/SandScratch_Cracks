using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "FeatureUnlockedPopupData", menuName = "GameSDK/FeatureUnlockedPopupData")]
	public class FeatureUnlockedPopupData : JScriptableObject
	{
		[Serializable]
		public struct Record
		{
			public GameFeatureType type;

			public string title;

			public VideoClip clip;

			[TextArea]
			public string description;
		}

		public Record[] records;
	}
}
