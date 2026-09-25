using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class TutorialChooseBooster : JEventTutorialStep, IStep
	{
		public BoosterType boosterType;

		private bool isComplete;

		private BtnTryExecuteBooster _boosterButton;

		public ATutorialHandIndicator hand;

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

		private void OnExcuteBooster(ref AEventManager.OnExecuteBooster eventData)
		{
		}

		private void OnTryExecuteBoosterPressed(ref AEventManager.OnTryExecuteBooster eventData)
		{
		}

		private void PointHandAtBoard()
		{
		}

		private void OnRevokeBoosterCanceled(ref AEventManager.OnRevokeBooster eventData)
		{
		}

		private void BlockExceptBoosterButton()
		{
		}

		public void Next()
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
