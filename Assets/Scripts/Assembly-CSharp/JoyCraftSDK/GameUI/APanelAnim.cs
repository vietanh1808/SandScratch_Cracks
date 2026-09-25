using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class APanelAnim : JMonoBehaviour
	{
		[Serializable]
		public enum AnimInType
		{
			None = 0,
			FromTop = 1,
			FromLeft = 2,
			FromRight = 3,
			FromBot = 4,
			FadeAlpha = 5,
			FromScale = 6
		}

		[Serializable]
		public enum AnimOutType
		{
			None = 0,
			ToTop = 1,
			ToLeft = 2,
			ToRight = 3,
			ToBot = 4,
			FadeAlpha = 5,
			ToScale = 6
		}

		public virtual void Setup(IAnimationTarget target)
		{
		}

		public virtual void StartAnimIn()
		{
		}

		public virtual void OnAnimInComplete()
		{
		}

		public virtual void StartAnimOut()
		{
		}

		public virtual void OnAnimOutComplete()
		{
		}

		public virtual bool AnimOutAvailable()
		{
			return false;
		}
	}
}
