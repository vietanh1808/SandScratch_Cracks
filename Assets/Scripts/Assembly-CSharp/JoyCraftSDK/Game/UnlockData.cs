using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class UnlockData
	{
		public GameFeatureType Type;

		public VideoClip FTUEClip;

		public Sprite Icon;
	}
}
