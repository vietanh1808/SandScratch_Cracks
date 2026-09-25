using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public class ButtonRestorePurchase : JButton
	{
		private bool _isRestoring;

		protected override void OnClick()
		{
		}

		private void OnRestoreFinished(RestoreResult result, int restoredCount)
		{
		}

		private static string GetMessage(RestoreResult result)
		{
			return null;
		}
	}
}
