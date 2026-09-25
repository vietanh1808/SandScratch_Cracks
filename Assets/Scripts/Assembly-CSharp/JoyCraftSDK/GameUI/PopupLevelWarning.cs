using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupLevelWarning : JUIPanel
	{
		[SerializeField]
		private GameObject hard;

		[SerializeField]
		private GameObject veryHard;

		private ReleaseDifficulty currentLevelDiff;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void Init()
		{
		}

		private void OnClose()
		{
		}
	}
}
