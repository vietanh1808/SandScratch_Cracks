using JoyCraftSDK.GameUI;
using JoyCraftSDK.JInput;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[RequireComponent(typeof(ABtnEvents))]
	[RequireComponent(typeof(AButtonAnimController))]
	public abstract class AButton : JMonoBehaviour
	{
		[SerializeField]
		protected ABtnEvents button;

		[SerializeField]
		protected AButtonAnimController buttonAnimController;

		[SerializeField]
		public TextMeshProUGUI text;

		protected abstract void OnClick();

		protected virtual void OnValidate()
		{
		}

		public void SetText(string newText)
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public bool GetInteractable()
		{
			return false;
		}

		public void Show(bool instant = false)
		{
		}

		public void Hide(bool instant = false)
		{
		}

		public bool IsShowing()
		{
			return false;
		}

		public abstract IClickableObject GetIClickableObject();
	}
}
