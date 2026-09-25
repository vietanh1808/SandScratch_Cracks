using JoyCraftSDK.JInput;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class ABtnEvents : JMonoBehaviour, IClickableObject
	{
		public Relay OnClick;

		public readonly Relay<bool> OnInteractableChange;

		public abstract void SetInteractable(bool interactable);

		public abstract bool GetInteractable();

		public abstract void OnObjectClicked();

		public abstract bool CanBeClicked();

		public abstract void SetCanBeClicked(bool canBeClicked);

		public abstract void OnClickBlocked();

		public abstract int GetUniqueID();
	}
}
