using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JoyCraftSDK.JInput
{
	public abstract class AJInputManager : JMonoBehaviour
	{
		public abstract bool IsInputEnabled { get; set; }

		public abstract Vector2 MousePosition { get; }

		public abstract InputAction ClickAction { get; }

		public abstract void Init(Action onComplete = null);

		public abstract void BlockAllExcept(IClickableObject allowedObject, float timeout = 0f);

		public abstract void BlockAllExcept(List<IClickableObject> allowedObjects, float timeout = 0f);

		public abstract void RestoreAllInput();

		public abstract bool CanObjectBeClicked(IClickableObject clickableObject);
	}
}
