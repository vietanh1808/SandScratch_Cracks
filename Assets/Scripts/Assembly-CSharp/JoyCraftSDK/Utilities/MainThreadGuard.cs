using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public static class MainThreadGuard
	{
		private static int _mainThreadId;

		public static bool IsMainThread => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void CaptureMainThread()
		{
		}
	}
}
