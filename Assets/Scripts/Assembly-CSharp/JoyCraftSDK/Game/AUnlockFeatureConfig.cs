using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	public abstract class AUnlockFeatureConfig : JScriptableObject
	{
		public abstract VideoClip GetClip(GameFeatureType type);

		public abstract Sprite GetIcon(GameFeatureType type);
	}
}
