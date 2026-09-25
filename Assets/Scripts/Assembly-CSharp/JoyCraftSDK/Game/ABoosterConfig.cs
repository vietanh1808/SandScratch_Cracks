using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	public abstract class ABoosterConfig : JScriptableObject
	{
		public abstract float AlphaRate { get; }

		public abstract float ShowTime { get; }

		public abstract VideoClip GetBoosterClip(BoosterType type);

		public abstract BoosterBtnData GetBoosterSprites(BoosterType type, bool isLocked);

		public abstract BoosterProgressIcons GetUnlockProgressIcons(BoosterType type);

		public abstract Sprite GetLockedSprite();

		public abstract Sprite GetRevokeSprite();

		public abstract Sprite GetWatchAdSprite();

		public abstract Sprite GetCountSprite();
	}
}
