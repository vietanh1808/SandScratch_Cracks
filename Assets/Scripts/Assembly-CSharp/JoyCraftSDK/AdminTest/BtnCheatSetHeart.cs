using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.AdminTest
{
	public class BtnCheatSetHeart : JButton
	{
		[SerializeField]
		private int heartCount;

		[SerializeField]
		private float secondsUntilNextHeart;

		protected override void OnClick()
		{
		}
	}
}
