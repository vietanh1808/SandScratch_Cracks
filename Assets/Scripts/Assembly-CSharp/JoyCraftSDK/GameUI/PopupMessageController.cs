using System;

namespace JoyCraftSDK.GameUI
{
	public class PopupMessageController : APopupMessageController
	{
		private bool _isShowing;

		public override void Show(string message, string title = "", Action onConfirm = null)
		{
		}

		public override void ShowWithAction(string message, string title, string actionLabel, Action onAction)
		{
		}

		public override void ShowText(string message, float autoHideSeconds = 0f, Action onClose = null)
		{
		}
	}
}
