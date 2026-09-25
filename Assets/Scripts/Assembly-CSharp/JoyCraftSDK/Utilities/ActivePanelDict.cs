using System;
using JoyCraftSDK.GameUI;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class ActivePanelDict : SerializedDictionary<UIPanelID, GuiManager.ActivePanelEntry>
	{
	}
}
