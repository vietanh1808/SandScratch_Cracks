using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ScreenGameplay : JUIPanel
	{
		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}

		public RectTransform GetBoosterButtonTransform(BoosterType boosterType)
		{
			return null;
		}
	}
}
