using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupNotice : JUIPanel
	{
		[SerializeField]
		private TextMeshProUGUI txtMessage;

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public void SetMsg(string msg)
		{
		}
	}
}
