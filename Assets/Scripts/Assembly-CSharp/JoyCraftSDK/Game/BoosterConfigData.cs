using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class BoosterConfigData
	{
		public BoosterType Type;

		public Sprite Icon;

		public Sprite IconProgress;

		public Sprite IconProgressLocked;

		public VideoClip Clip;
	}
}
