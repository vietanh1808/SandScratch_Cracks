using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class TutorialClickPopupBooster : JEventTutorialStep, IStep
	{
		public BoosterType boosterType;

		public ATutorialHandIndicator hand;

		private bool isComplete;

		public bool IsComplete
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public void Next()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}
	}
}
