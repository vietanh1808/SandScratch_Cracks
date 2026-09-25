using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JoyCraftSDK.JInput
{
	public class JInputManager : AJInputManager
	{
		[Header("Input Actions")]
		[SerializeField]
		private InputActionAsset inputActions;

		[Header("State")]
		[SerializeField]
		private bool isInputEnabled;

		private InputAction _mousePositionAction;

		private InputAction _clickAction;

		private Vector2 _mousePosition;

		private readonly HashSet<int> _allowedObjectIds;

		private readonly List<string> _debugAllowedNames;

		public override bool IsInputEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override Vector2 MousePosition => default;

		public override InputAction ClickAction => null;

		public override void Awake()
		{
		}

		private void InitInputActions()
		{
		}

		public override void Init(Action onComplete = null)
		{
		}

		public override void BlockAllExcept(IClickableObject allowedObject, float timeout = 0f)
		{
		}

		public override void BlockAllExcept(List<IClickableObject> allowedObjects, float timeout = 0f)
		{
		}

		public override void RestoreAllInput()
		{
		}

		public override bool CanObjectBeClicked(IClickableObject clickableObject)
		{
			return false;
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnUpdate(ref AEventManager.OnUpdate eventdata)
		{
		}
	}
}
