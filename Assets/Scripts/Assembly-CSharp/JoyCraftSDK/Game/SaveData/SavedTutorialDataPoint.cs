using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game.SaveData
{
	[Serializable]
	public class SavedTutorialDataPoint
	{
		[SerializeField]
		public TutorialType type;

		[SerializeField]
		public bool isCompleted;
	}
}
