using System.Collections.Generic;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(menuName = "GameSDK/BoosterConfig", fileName = "Config")]
	public class BoosterConfig : ABoosterConfig
	{
		private const string Group_Bg = "Backgrounds";

		private const string Group_Fade = "Fade";

		[SerializeField]
		private List<BoosterConfigData> configData;

		[SerializeField]
		private SpriteData btnBg;

		[SerializeField]
		private Sprite btnLockedBg;

		[SerializeField]
		private Sprite lockedLevelBg;

		[SerializeField]
		private Sprite countBg;

		[SerializeField]
		private Sprite revokeBg;

		[SerializeField]
		private Sprite watchAdBg;

		[SerializeField]
		private float alphaRate;

		[SerializeField]
		private float showTime;

		public override float AlphaRate => 0f;

		public override float ShowTime => 0f;

		public override VideoClip GetBoosterClip(BoosterType type)
		{
			return null;
		}

		protected virtual ReleaseDifficulty CurrentDifficulty()
		{
			return (ReleaseDifficulty)0;
		}

		public override BoosterBtnData GetBoosterSprites(BoosterType type, bool isLocked)
		{
			return null;
		}

		public override BoosterProgressIcons GetUnlockProgressIcons(BoosterType type)
		{
			return null;
		}

		public override Sprite GetRevokeSprite()
		{
			return null;
		}

		public override Sprite GetWatchAdSprite()
		{
			return null;
		}

		public override Sprite GetCountSprite()
		{
			return null;
		}

		public override Sprite GetLockedSprite()
		{
			return null;
		}

		private Sprite GetIcon(BoosterType type, bool isLocked)
		{
			return null;
		}

		private VideoClip GetClip(BoosterType type)
		{
			return null;
		}
	}
}
