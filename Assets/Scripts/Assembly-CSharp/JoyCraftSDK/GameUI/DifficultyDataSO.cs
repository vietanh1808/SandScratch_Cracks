using JoyCraftSDK.Utilities;
using UnityEngine;
using nickeltin.SDF.Runtime;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(menuName = "GameSDK/DifficultyDataSO", fileName = "DifficultyDataSO")]
	public class DifficultyDataSO : ADifficultyDataSO
	{
		[SerializeField]
		private SpriteDictionary Sprites;

		public override Sprite GetSprite(UIObjectType type, int level = -1)
		{
			return null;
		}

		public override Sprite GetCurrentSprite(UIObjectType type, int level = -1)
		{
			return null;
		}

		public override SDFSpriteReference GetSdfSprite(UIObjectType type, int level = -1)
		{
			return default;
		}

		public override SDFSpriteReference GetCurrentSdfSprite(UIObjectType type, int level = -1)
		{
			return default;
		}

		private Sprite GetSprite(ReleaseDifficulty lvlDiff, SpriteData data)
		{
			return null;
		}

		private SDFSpriteReference GetSdfSprite(UIObjectType type, ReleaseDifficulty lvlDiff, SdfSpriteData sdf)
		{
			return default;
		}
	}
}
