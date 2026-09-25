using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnNextLevel : JButton
	{
		[SerializeField]
		private JUIPanel _panel;

		[SerializeField]
		private TxtCoin coinText;

		[SerializeField]
		private TextMeshProUGUI rewardText;

		[SerializeField]
		private AWinFlowController winFlow;

		private bool isCanTouch;

		private bool winResolved;

		private int coinAmount;

		protected override void OnClick()
		{
		}

		protected override void OnEnable()
		{
		}

		private void ResolveWin()
		{
		}

		private void PlayTransitionToHome()
		{
		}

		private void PlayTransitionThenNextLevel()
		{
		}
	}
}
