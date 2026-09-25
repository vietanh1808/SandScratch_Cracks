using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class GameUIController : AGameUIController
	{
		[SerializeField]
		private bool showWin;

		private void OnLevelLoseCondition(ref AEventManager.OnLevelLoseCondition eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
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
