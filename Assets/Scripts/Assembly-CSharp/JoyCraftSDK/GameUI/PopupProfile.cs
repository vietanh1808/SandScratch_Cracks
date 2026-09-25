using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupProfile : JUIPanel
	{
		[SerializeField]
		private TMP_Text levelValueText;

		[SerializeField]
		private TMP_Text firstTryWinText;

		[SerializeField]
		private TMP_Text highestWinStreakText;

		[SerializeField]
		private TMP_Text activeWinStreakText;

		[SerializeField]
		private Image avatarImage;

		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private TMP_Text playerNameText;

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

		protected override void RegisterEvent()
		{
		}

		protected override void UnregisterEvent()
		{
		}

		private void OnProfileChanged(ref AEventManager.OnProfileChanged eventData)
		{
		}

		private void Refresh()
		{
		}
	}
}
