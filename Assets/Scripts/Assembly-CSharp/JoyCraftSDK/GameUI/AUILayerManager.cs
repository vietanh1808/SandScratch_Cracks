using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AUILayerManager : JMonoBehaviour
	{
		[SerializeField]
		protected Canvas _layerCanvas;

		protected new AGuiManager _guiManager;

		protected readonly List<AUIPanel> _panels;

		protected readonly List<AUIPanel> _inactivePool;

		public Canvas LayerCanvas => null;

		public void Initialize(AGuiManager guiManager, Canvas canvas)
		{
		}

		public virtual bool GetActivePanelID(out UIPanelID panel)
		{
			panel = default;
			return false;
		}

		public virtual AUIPanel ShowPanel(UIPanelID panelID, AUIPanel prefab)
		{
			return null;
		}

		public virtual void HidePanel(UIPanelID panelID, AUIPanel instance)
		{
		}

		public virtual bool HasActivePanel()
		{
			return false;
		}

		public virtual void ClearLayer()
		{
		}

		protected AUIPanel TakeOrInstantiate(UIPanelID panelID, AUIPanel prefab)
		{
			return null;
		}

		protected AUIPanel InstantiatePanel(AUIPanel prefab)
		{
			return null;
		}

		protected void DestroyAllChildren()
		{
		}
	}
}
