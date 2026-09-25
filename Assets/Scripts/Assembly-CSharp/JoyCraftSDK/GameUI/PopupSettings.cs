using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class PopupSettings : JUIPanel
	{
		[SerializeField]
		private Toggle sfxTgl;

		[SerializeField]
		private Toggle musicTgl;

		[SerializeField]
		private Toggle hapticTgl;

		[SerializeField]
		private GameObject homeBtn;

		[SerializeField]
		private GameObject supportBtn;

		[SerializeField]
		private GameObject adminTestBtn;

		[SerializeField]
		private TextMeshProUGUI version;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		protected override void Init()
		{
		}

		private void RefreshAdminTestBtn()
		{
		}

		private void OnAdminTestUnlocked(ref AEventManager.OnAdminTestUnlocked eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
