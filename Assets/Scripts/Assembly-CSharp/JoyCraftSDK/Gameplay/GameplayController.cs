using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Gameplay
{
	public class GameplayController : AGameplayController
	{
		private bool _finishRaised;

		public override void RaiseLevelFinished(LevelFinishReason reason, LevelFailReason failReason)
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public override void TryLoadCurrentLevel(Action IfSuccess, LevelPlayType playType)
		{
		}

		public override void CloseScreenLose()
		{
		}

		public override void TryRetryMidGame()
		{
		}

		public override void TryQuitLevel()
		{
		}

		public override void QuitLevel()
		{
		}

		public override void TryPlayOn()
		{
		}

		public override void PlayOnFromAds()
		{
		}

		public override void PlayOnFromPurchase()
		{
		}

		private void ExecutePlayOn()
		{
		}

		public override void WinLevelFromPurchase()
		{
		}

		public override void SkipLevel()
		{
		}

		public override void CheckLoseCondition()
		{
		}
	}
}
