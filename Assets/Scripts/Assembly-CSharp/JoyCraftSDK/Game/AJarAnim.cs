using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class AJarAnim : JMonoBehaviour
	{
		public abstract void SetHighlightEffect(bool isActive);

		public abstract void SetHeadOutline(bool isActive, Color color);

		public abstract void Init(GameObjectColor color);

		public abstract void PlayAnimOpen(Action onComplete);

		public abstract void PlayAnimClose();

		public abstract void PlayEffectFill(Action onComplete);

		public abstract void PlayEffectMerge(Action onComplete);

		public abstract void SetHidden(bool isHidden);

		public abstract void PlayRevealBurst();

		public abstract void PlayAnimCollapse(Action onComplete);

		public abstract void PlayEffectFill(float progress);
	}
}
