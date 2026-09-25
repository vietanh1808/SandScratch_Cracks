using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "JTutorialUIEvents", menuName = "Tutorial/JEventUI")]
	public class JTutorialUIEvents : JScriptableObject
	{
		public void TryClickBoosterPlanePicker()
		{
		}

		public void TryClickBoosterColorPicker()
		{
		}

		public void TryClickBoosterShuffle()
		{
		}

		protected virtual void RaiseTutorialBooster(BoosterType type)
		{
		}
	}
}
