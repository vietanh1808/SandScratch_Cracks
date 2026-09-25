using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupEditProfile : JUIPanel
	{
		private const int MaxNameLength = 16;

		[SerializeField]
		private TMP_InputField playerNameInput;

		[SerializeField]
		private ProfileItemScroll avatarScroll;

		[SerializeField]
		private ProfileItemScroll frameScroll;

		private string _pendingName;

		private string _pendingAvatarId;

		private string _pendingFrameId;

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

		private void OnAvatarSelected(string id)
		{
		}

		private void OnFrameSelected(string id)
		{
		}

		public void RandomizeName()
		{
		}

		public void SaveAndClose()
		{
		}
	}
}
