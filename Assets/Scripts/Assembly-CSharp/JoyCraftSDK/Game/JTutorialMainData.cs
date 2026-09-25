using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "JTutorialMainData", menuName = "Tutorial/MainData")]
	public class JTutorialMainData : JScriptableObject
	{
		public bool isActive;

		public TutorialFlow[] flows;
	}
}
