using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnRetryPopup : JButton
	{
		[SerializeField]
		private AUIPanel _panel;

		public Action OnPopupClosed;

		protected override void OnClick()
		{
		}

		private void FeedBackAfterReloadSuccess()
		{
		}

		private void ClosePopup()
		{
		}
	}
}
