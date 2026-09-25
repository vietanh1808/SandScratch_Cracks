using TouchScript.InputSources.InputHandlers;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;

namespace TouchScript.InputSources
{
	[AddComponentMenu("TouchScript/Input Sources/Standard Input")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_InputSources_StandardInput.htm")]
	public sealed class StandardInput : InputSource
	{
		public enum Windows8APIType
		{
			Windows8 = 0,
			Windows7 = 1,
			Unity = 2,
			None = 3
		}

		public enum Windows7APIType
		{
			Windows7 = 0,
			Unity = 1,
			None = 2
		}

		private static StandardInput instance;

		[SerializeField]
		[HideInInspector]
		private bool generalProps;

		[SerializeField]
		[HideInInspector]
		private bool windowsProps;

		[SerializeField]
		[HideInInspector]
		private bool webglProps;

		[SerializeField]
		private Windows8APIType windows8API;

		[SerializeField]
		private Windows7APIType windows7API;

		[ToggleLeft]
		[SerializeField]
		private bool webGLTouch;

		[ToggleLeft]
		[SerializeField]
		private bool windows8Mouse;

		[ToggleLeft]
		[SerializeField]
		private bool windows7Mouse;

		[ToggleLeft]
		[SerializeField]
		private bool universalWindowsMouse;

		[ToggleLeft]
		[SerializeField]
		private bool emulateSecondMousePointer;

		private MouseHandler mouseHandler;

		private TouchHandler touchHandler;

		public Windows8APIType Windows8API => Windows8APIType.Windows8;

		public Windows7APIType Windows7API => Windows7APIType.Windows7;

		public bool WebGLTouch => false;

		public bool Windows8Mouse => false;

		public bool Windows7Mouse => false;

		public bool UniversalWindowsMouse => false;

		public bool EmulateSecondMousePointer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool UpdateInput()
		{
			return false;
		}

		public override void UpdateResolution()
		{
		}

		public override bool CancelPointer(Pointer pointer, bool shouldReturn)
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		[ContextMenu("Basic Editor")]
		private void switchToBasicEditor()
		{
		}

		protected override void updateCoordinatesRemapper(ICoordinatesRemapper remapper)
		{
		}

		private void enableMouse()
		{
		}

		private void disableMouse()
		{
		}

		private void enableTouch()
		{
		}

		private void disableTouch()
		{
		}
	}
}
