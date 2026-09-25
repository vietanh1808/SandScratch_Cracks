using System;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	[CreateAssetMenu(fileName = "JSwitchToggleBgData", menuName = "JoyCraft/UI Data/Background Data/Switch Toggle")]
	public class JSwitchToggleBgData : ASwitchToggleBgData
	{
		[SerializeField]
		private Sprite activeBg;

		[SerializeField]
		private Sprite inactiveBg;

		public override Sprite GetBackgroundSprite(bool active)
		{
			return null;
		}
	}
}
