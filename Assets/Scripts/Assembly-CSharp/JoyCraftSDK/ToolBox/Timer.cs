using System;

namespace JoyCraftSDK.ToolBox
{
	[Serializable]
	public class Timer : ATimer
	{
		private bool _isSubscribed;

		public override void Init(float durationInSeconds)
		{
		}

		public override void Start()
		{
		}

		public override void Restart()
		{
		}

		public override void Pause()
		{
		}

		public override void Resume()
		{
		}

		public override void Reset()
		{
		}

		public override void AddTime(float seconds)
		{
		}

		public override void MinusTime(float seconds)
		{
		}

		private void SubscribeToGameTime()
		{
		}

		private void UnsubscribeFromGameTime()
		{
		}

		private void OnGameTimeTick(ref AEventManager.OnEverySecondTickGameTime eventData)
		{
		}

		private bool TryFinishTimer()
		{
			return false;
		}
	}
}
