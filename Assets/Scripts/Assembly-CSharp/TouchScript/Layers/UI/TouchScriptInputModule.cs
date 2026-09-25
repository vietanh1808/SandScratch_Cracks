using System.Collections.Generic;
using System.Reflection;
using TouchScript.Hit;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Profiling;

namespace TouchScript.Layers.UI
{
	internal sealed class TouchScriptInputModule : BaseInputModule
	{
		private class UIStandardInputModule
		{
			protected TouchScriptInputModule input;

			private CustomSampler uiSampler;

			private int m_ConsecutiveMoveCount;

			private Vector2 m_LastMoveVector;

			private float m_PrevActionTime;

			private Dictionary<int, PointerEventData> m_PointerData;

			public UIStandardInputModule(TouchScriptInputModule input)
			{
			}

			public bool IsPointerOverGameObject(int pointerId)
			{
				return false;
			}

			protected bool GetPointerData(int id, out PointerEventData data, bool create)
			{
				data = null;
				return false;
			}

			protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
			{
			}

			protected PointerEventData GetLastPointerEventData(int id)
			{
				return null;
			}

			private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
			{
				return false;
			}

			private bool SendUpdateEventToSelectedObject()
			{
				return false;
			}

			private bool SendMoveEventToSelectedObject()
			{
				return false;
			}

			private bool SendSubmitEventToSelectedObject()
			{
				return false;
			}

			private Vector2 GetRawMoveVector()
			{
				return default;
			}

			public void Process()
			{
			}

			protected void RemovePointerData(int id)
			{
			}

			private void convertRaycast(RaycastHitUI old, ref RaycastResult current)
			{
			}

			public virtual void ProcessUpdated(object sender, PointerEventArgs pointerEventArgs)
			{
			}

			public virtual void ProcessPressed(object sender, PointerEventArgs pointerEventArgs)
			{
			}

			public virtual void ProcessReleased(object sender, PointerEventArgs pointerEventArgs)
			{
			}

			public virtual void ProcessCancelled(object sender, PointerEventArgs pointerEventArgs)
			{
			}

			public virtual void ProcessRemoved(object sender, PointerEventArgs pointerEventArgs)
			{
			}
		}

		public string HorizontalAxis;

		public string VerticalAxis;

		public string SubmitButton;

		public string CancelButton;

		public float InputActionsPerSecond;

		public float RepeatDelay;

		private static bool shuttingDown;

		private static TouchScriptInputModule instance;

		private static FieldInfo raycastersProp;

		private static PropertyInfo canvasProp;

		private static Dictionary<int, Canvas> raycasterCanvasCache;

		private int refCount;

		private UIStandardInputModule ui;

		public static TouchScriptInputModule Instance => null;

		private TouchScriptInputModule()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public List<BaseRaycaster> GetRaycasters()
		{
			return null;
		}

		public Canvas GetCanvasForRaycaster(BaseRaycaster raycaster)
		{
			return null;
		}

		public override void Process()
		{
		}

		public override bool IsPointerOverGameObject(int pointerId)
		{
			return false;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override void DeactivateModule()
		{
		}

		public override void ActivateModule()
		{
		}

		public override void UpdateModule()
		{
		}

		internal void INTERNAL_Retain()
		{
		}

		internal int INTERNAL_Release()
		{
			return 0;
		}

		private void enable()
		{
		}

		private void disable()
		{
		}
	}
}
