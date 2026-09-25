using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Analytics
{
	public class AbandonLifecycleManager : JMonoBehaviour
	{
		[SerializeField]
		private float abandonThresholdMinutes;

		private void OnAppPause(ref AEventManager.OnApplicationPauseEvent eventData)
		{
		}

		private void OnAppFocus(ref AEventManager.OnApplicationFocusEvent eventData)
		{
		}

		private void OnGameInited(ref AEventManager.OnGameInited eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void CapturePending()
		{
		}

		private void ResolvePending()
		{
		}

		private void ClearPending()
		{
		}

		private void EmitAbandonExit(SavedPendingAbandonData pendingAbandon)
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
