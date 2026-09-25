using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AColorHammerAnim : JMonoBehaviour
	{
		public abstract void PlayShow(Action onComplete);

		public abstract void PlayHit(Action onComplete);

		public abstract void PlayHide(Action onComplete);
	}
}
