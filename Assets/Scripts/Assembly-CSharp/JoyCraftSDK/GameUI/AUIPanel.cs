using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.GameUI
{
	public abstract class AUIPanel : JMonoBehaviour
	{
		[FormerlySerializedAs("root")]
		public Canvas _root;

		public APanelAnim panelAnimator;

		[SerializeField]
		private UILayer _defaultLayer;

		public UILayer DefaultLayer => UILayer.None;

		public bool IsClosing { get; protected set; }

		public abstract UIPanelID GetId();

		protected abstract void Init();

		public virtual void OnAppear()
		{
		}

		public virtual void OnDisappear()
		{
		}

		public virtual void CloseInternal()
		{
		}

		public virtual void SetActiveFalse()
		{
		}
	}
}
