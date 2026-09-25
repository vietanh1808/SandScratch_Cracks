using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.GameUI
{
	public class GuiManager : AGuiManager
	{
		[Serializable]
		public struct ActivePanelEntry
		{
			public AUIPanel panel;

			public UILayer layer;
		}

		private struct LayerEntry
		{
			public UILayer layer;

			public Canvas canvas;

			public AUILayerManager manager;
		}

		private const string RuntimeGroup = "Runtime";

		private const string FieldGroup = "Fields";

		private const string LayerManagerGroup = "Layer Managers";

		[SerializeField]
		public Canvas layerBase;

		[SerializeField]
		public Canvas layerFlow;

		[FormerlySerializedAs("layerTop")]
		[SerializeField]
		public Canvas layerPopup;

		[SerializeField]
		public Canvas layerTutorial;

		[SerializeField]
		public Canvas layerEffect;

		[SerializeField]
		public AUILoading loadingUi;

		[SerializeField]
		private ActivePanelDict _activeRegistry;

		[SerializeField]
		private UILayerManagerBase _layerManagerBase;

		[SerializeField]
		private UILayerManagerFlow _layerManagerFlow;

		[SerializeField]
		private UILayerManagerTutorial _layerManagerTutorial;

		[FormerlySerializedAs("_layerManagerTop")]
		[SerializeField]
		private UILayerManagerPopup _layerManagerPopup;

		[SerializeField]
		private UILayerManagerEffect _layerManagerEffect;

		private LayerEntry[] _layers;

		public override UILayerManagerEffect LayerEffect => null;

		public override bool HasActivePanel(UILayer layer)
		{
			return false;
		}

		public override Canvas GetLayerCanvas(UILayer layer)
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void BuildLayerTable()
		{
		}

		private void InitializeLayerManagers()
		{
		}

		public override AUIPanel ShowPanel(UIPanelID panelID)
		{
			return null;
		}

		public override AUIPanel ShowPanel(UIPanelID panelID, UILayer layer)
		{
			return null;
		}

		public override void HidePanel(UIPanelID panelID)
		{
		}

		public override void HideAllPanels()
		{
		}

		private void HidePanelsInternal()
		{
		}

		public override bool TryGetActivePanel(UIPanelID panelID, out AUIPanel panel, out UILayer layer)
		{
			panel = null;
			layer = default;
			return false;
		}

		public override void ClearGui()
		{
		}

		public override UIPanelID GetTopPanelID()
		{
			return UIPanelID.None;
		}

		private AUILayerManager ResolveLayerManager(UILayer layer)
		{
			return null;
		}

		public override void StartLoadingUI(bool resetProgressBar)
		{
		}

		public override void DisableLoadingUI()
		{
		}

		public override void SetLoadingProgress(float to, float speed)
		{
		}

		private AUIPanel GetPanelPrefab(UIPanelID panelID)
		{
			return null;
		}
	}
}
