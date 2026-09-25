using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AFrameRateManager : JMonoBehaviour
	{
		public abstract void SetFPS(int fps);

		public abstract void Init(Action onComplete = null);
	}
}
