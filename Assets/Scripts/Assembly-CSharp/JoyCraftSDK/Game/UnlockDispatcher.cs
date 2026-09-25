using System.Collections.Generic;

namespace JoyCraftSDK.Game
{
	public class UnlockDispatcher : AUnlockDispatcher
	{
		private readonly Queue<UnlockEntry> pendingUnlocks;

		private UnlockEntry showingUnlock;

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void OnUnlockPopupClosed(ref AEventManager.OnUnlockPopupClosed eventData)
		{
		}

		private void OnLevelUnloaded(ref AEventManager.OnLevelUnloaded eventData)
		{
		}

		private void ShowNext()
		{
		}

		private bool IsFTUEShowed(UnlockEntry entry)
		{
			return false;
		}

		private void FinishFTUE(UnlockEntry entry)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
