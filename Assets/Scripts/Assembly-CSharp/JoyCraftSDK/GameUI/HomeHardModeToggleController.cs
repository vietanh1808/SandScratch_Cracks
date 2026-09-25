using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HomeHardModeToggleController : JMonoBehaviour
	{
		[Tooltip("GameObject của nút BtnToggleLevelDatabase (child của ScreenHome).")]
		[SerializeField]
		private GameObject hardModeToggleButton;

		[Tooltip("Level tối thiểu để nút HARD hiện ra. Level hiện tại >= số này thì hiện.")]
		[SerializeField]
		private int unlockAtLevel;

		protected override void OnEnable()
		{
		}

		private void ApplyVisibility()
		{
		}
	}
}
