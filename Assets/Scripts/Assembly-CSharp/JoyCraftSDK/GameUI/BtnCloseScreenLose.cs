using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnCloseScreenLose : JButton
	{
		[SerializeField]
		private ScreenLose screenLose;

		protected override bool SkipDoubleClickProtection => false;

		protected override void OnClick()
		{
		}
	}
}
