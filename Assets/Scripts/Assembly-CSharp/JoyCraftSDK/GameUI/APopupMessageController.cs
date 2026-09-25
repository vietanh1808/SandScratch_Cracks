using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class APopupMessageController : JMonoBehaviour
	{
		public abstract void Show(string message, string title = "", Action onConfirm = null);

		public abstract void ShowWithAction(string message, string title, string actionLabel, Action onAction);

		public abstract void ShowText(string message, float autoHideSeconds = 0f, Action onClose = null);
	}
}
