using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnAdminTest : JButton
	{
		[SerializeField]
		private AUIPanel _panel;

		public Action OnPopupClosed;

		protected override void OnClick()
		{
		}
	}
}
