using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupPreLevel : JUIPanel
	{
		[SerializeField]
		private TMP_Text titleText;

		[SerializeField]
		private GameObject giftRoot;

		[SerializeField]
		private WinStreakView winStreakView;

		protected override void Init()
		{
		}

		protected override void OnAppearInternal()
		{
		}

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		private void Refresh()
		{
		}
	}
}
