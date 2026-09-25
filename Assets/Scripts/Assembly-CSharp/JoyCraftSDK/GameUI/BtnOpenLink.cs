using JoyCraftSDK.ExternalLink;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BtnOpenLink : JButton
	{
		[SerializeField]
		private ExternalLinkID linkID;

		protected override void OnClick()
		{
		}
	}
}
