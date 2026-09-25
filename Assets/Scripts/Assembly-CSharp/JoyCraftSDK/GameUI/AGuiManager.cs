using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AGuiManager : JMonoBehaviour
	{
		public abstract UILayerManagerEffect LayerEffect { get; }

		public abstract bool HasActivePanel(UILayer layer);

		public abstract Canvas GetLayerCanvas(UILayer layer);

		public abstract AUIPanel ShowPanel(UIPanelID panelID);

		public abstract AUIPanel ShowPanel(UIPanelID panelID, UILayer layer);

		public abstract void HidePanel(UIPanelID panelID);

		public abstract void HideAllPanels();

		public abstract bool TryGetActivePanel(UIPanelID panelID, out AUIPanel panel, out UILayer layer);

		public abstract void ClearGui();

		public abstract UIPanelID GetTopPanelID();

		public abstract void DisableLoadingUI();

		public abstract void StartLoadingUI(bool resetProgressBar);

		public abstract void SetLoadingProgress(float to, float speed);
	}
}
