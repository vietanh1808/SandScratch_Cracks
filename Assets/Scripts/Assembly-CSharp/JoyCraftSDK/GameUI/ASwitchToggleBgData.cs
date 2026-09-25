using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class ASwitchToggleBgData : JScriptableObject
	{
		public abstract Sprite GetBackgroundSprite(bool active);
	}
}
