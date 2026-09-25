using System.Collections.Generic;
using TouchScript.Utils;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Behaviors.Cursors
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_CursorManager.htm")]
	public class CursorManager : MonoBehaviour
	{
		[SerializeField]
		private bool cursorsProps;

		[SerializeField]
		private PointerCursor mouseCursor;

		[SerializeField]
		private PointerCursor touchCursor;

		[SerializeField]
		private PointerCursor penCursor;

		[SerializeField]
		private PointerCursor objectCursor;

		[SerializeField]
		[ToggleLeft]
		private bool useDPI;

		[SerializeField]
		private float cursorSize;

		[SerializeField]
		private uint cursorPixelSize;

		private RectTransform rect;

		private ObjectPool<PointerCursor> mousePool;

		private ObjectPool<PointerCursor> touchPool;

		private ObjectPool<PointerCursor> penPool;

		private ObjectPool<PointerCursor> objectPool;

		private Dictionary<int, PointerCursor> cursors;

		private CustomSampler cursorSampler;

		public PointerCursor MouseCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointerCursor TouchCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointerCursor PenCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointerCursor ObjectCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseDPI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CursorSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public uint CursorPixelSize
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private PointerCursor instantiateMouseProxy()
		{
			return null;
		}

		private PointerCursor instantiateTouchProxy()
		{
			return null;
		}

		private PointerCursor instantiatePenProxy()
		{
			return null;
		}

		private PointerCursor instantiateObjectProxy()
		{
			return null;
		}

		private void clearProxy(PointerCursor cursor)
		{
		}

		private void updateCursorSize()
		{
		}

		private void pointersAddedHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersRemovedHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersPressedHandler(object sender, PointerEventArgs e)
		{
		}

		private void PointersUpdatedHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersReleasedHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersCancelledHandler(object sender, PointerEventArgs e)
		{
		}
	}
}
