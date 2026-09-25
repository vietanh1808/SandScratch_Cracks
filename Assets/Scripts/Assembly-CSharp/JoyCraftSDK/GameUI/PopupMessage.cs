using System;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupMessage : JUIPanel
	{
		[SerializeField]
		private TextMeshProUGUI _txtTitle;

		[SerializeField]
		private TextMeshProUGUI _txtMessage;

		[SerializeField]
		private BtnPopupAction _btnAction;

		[SerializeField]
		private GameObject[] _decorations;

		private Action _onConfirm;

		private int _showToken;

		protected override void Init()
		{
		}

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public void SetMessage(string message, string title = "", Action onConfirm = null)
		{
		}

		public void SetMessageWithAction(string message, string title, string actionLabel, Action onAction, Action onClose)
		{
		}

		public void SetTextOnly(string message, float autoHideSeconds = 0f, Action onClose = null)
		{
		}

		public void OnConfirm()
		{
		}

		private void RestoreChrome()
		{
		}

		private void SetDecorationsActive(bool active)
		{
		}

		private void ScheduleAutoHide(float seconds)
		{
		}
	}
}
