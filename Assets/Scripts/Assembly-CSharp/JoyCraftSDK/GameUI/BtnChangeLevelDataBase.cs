using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnChangeLevelDataBase : JButton
	{
		[SerializeField]
		private ALevelDatabase database;

		protected override void OnClick()
		{
		}
	}
}
