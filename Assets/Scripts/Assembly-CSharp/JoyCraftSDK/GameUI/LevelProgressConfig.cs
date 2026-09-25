using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(menuName = "JoyCraft/Configs/LevelProgress", fileName = "LevelProgressConfig")]
	public class LevelProgressConfig : JScriptableObject
	{
		public float updateDuration;

		public EasingType easingType;
	}
}
