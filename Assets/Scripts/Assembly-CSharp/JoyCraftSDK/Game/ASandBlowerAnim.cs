using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ASandBlowerAnim : JMonoBehaviour
	{
		public abstract void PlayAppear(Action onComplete);

		public abstract void PlayBlow(Action onComplete);

		public abstract void StopBlow();

		public abstract void PlayDisappear(Action onComplete);

		public abstract void PlayIdle();
	}
}
