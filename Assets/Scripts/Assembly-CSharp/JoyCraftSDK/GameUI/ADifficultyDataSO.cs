using JoyCraftSDK.Utilities;
using UnityEngine;
using nickeltin.SDF.Runtime;

namespace JoyCraftSDK.GameUI
{
	public abstract class ADifficultyDataSO : JScriptableObject
	{
		public abstract Sprite GetSprite(UIObjectType type, int level = -1);

		public abstract Sprite GetCurrentSprite(UIObjectType type, int level = -1);

		public abstract SDFSpriteReference GetSdfSprite(UIObjectType type, int level = -1);

		public abstract SDFSpriteReference GetCurrentSdfSprite(UIObjectType type, int level = -1);
	}
}
