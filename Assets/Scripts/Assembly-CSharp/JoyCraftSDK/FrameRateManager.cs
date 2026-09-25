using System;

namespace JoyCraftSDK
{
	public class FrameRateManager : AFrameRateManager
	{
		private const int PauseFPS = 1;

		private const int NormalFPS = 60;

		public override void SetFPS(int fps)
		{
		}

		public override void Init(Action onComplete = null)
		{
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}
	}
}
