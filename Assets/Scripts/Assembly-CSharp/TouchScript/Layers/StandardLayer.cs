using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TouchScript.Hit;
using TouchScript.Layers.UI;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TouchScript.Layers
{
	[AddComponentMenu("TouchScript/Layers/Standard Layer")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Layers_StandardLayer.htm")]
	public class StandardLayer : TouchLayer
	{
		[CompilerGenerated]
		private sealed class _003ClateEnable_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardLayer _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003ClateEnable_003Ed__46(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static Comparison<RaycastHitUI> _raycastHitUIComparerFunc;

		private static Comparison<RaycastHit> _raycastHitComparerFunc;

		private static Comparison<HitData> _hitDataComparerFunc;

		private static Dictionary<int, ProjectionParams> projectionParamsCache;

		private static List<BaseRaycaster> raycasters;

		private static List<RaycastHitUI> raycastHitUIList;

		private static List<RaycastHit> raycastHitList;

		private static List<HitData> hitList;

		private static RaycastHit[] raycastHits;

		private static RaycastHit2D[] raycastHits2D;

		[SerializeField]
		[HideInInspector]
		private bool basicEditor;

		[SerializeField]
		[HideInInspector]
		private bool advancedProps;

		[SerializeField]
		[HideInInspector]
		private bool hitProps;

		[SerializeField]
		[ToggleLeft]
		private bool hit3DObjects;

		[SerializeField]
		[ToggleLeft]
		private bool hit2DObjects;

		[SerializeField]
		[ToggleLeft]
		private bool hitWorldSpaceUI;

		[SerializeField]
		[ToggleLeft]
		private bool hitScreenSpaceUI;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		[ToggleLeft]
		private bool useHitFilters;

		private bool lookForCameraObjects;

		private TouchScriptInputModule inputModule;

		protected Camera _camera;

		public bool Hit3DObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Hit2DObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HitWorldSpaceUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HitScreenSpaceUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseHitFilters
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LayerMask LayerMask
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public override Vector3 WorldProjectionNormal => default;

		public override HitResult Hit(IPointer pointer, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		public override ProjectionParams GetProjectionParams(Pointer pointer)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003ClateEnable_003Ed__46))]
		private IEnumerator lateEnable()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		[ContextMenu("Basic Editor")]
		private void switchToBasicEditor()
		{
		}

		protected virtual void updateCamera()
		{
		}

		protected override ProjectionParams createProjectionParams()
		{
			return null;
		}

		protected override void setName()
		{
		}

		private void setupInputModule()
		{
		}

		private HitResult performWorldSearch(IPointer pointer, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		private HitResult performSSUISearch(IPointer pointer, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		private void performUISearchForCanvas(IPointer pointer, Canvas canvas, GraphicRaycaster raycaster, Camera eventCamera = null, float maxDistance = 3.4028235E+38f, Ray ray = default(Ray))
		{
		}

		private HitResult doHit(IPointer pointer, RaycastHitUI raycastHit, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		private HitResult doHit(IPointer pointer, RaycastHit raycastHit, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		private void updateVariants()
		{
		}

		private static int raycastHitUIComparerFunc(RaycastHitUI lhs, RaycastHitUI rhs)
		{
			return 0;
		}

		private static int raycastHitComparerFunc(RaycastHit lhs, RaycastHit rhs)
		{
			return 0;
		}

		private static int hitDataComparerFunc(HitData lhs, HitData rhs)
		{
			return 0;
		}

		private void frameStartedHandler(object sender, EventArgs eventArgs)
		{
		}
	}
}
