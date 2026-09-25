using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Button))]
	public class BtnEvents : ABtnEvents
	{
		[SerializeField]
		private Button _unityBtn;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void BtnClickAction()
		{
		}

		private void OnValidate()
		{
		}

		public override void SetInteractable(bool interactable)
		{
		}

		public override bool GetInteractable()
		{
			return false;
		}

		public override void OnObjectClicked()
		{
		}

		public override bool CanBeClicked()
		{
			return false;
		}

		public override void SetCanBeClicked(bool canBeClicked)
		{
		}

		public override void OnClickBlocked()
		{
		}

		public override int GetUniqueID()
		{
			return 0;
		}
	}
}
