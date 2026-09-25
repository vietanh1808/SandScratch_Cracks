using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TouchScript.Hit;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Layers
{
	[ExecuteInEditMode]
	public abstract class TouchLayer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003ClateAwake_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TouchLayer _003C_003E4__this;

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
			public _003ClateAwake_003Ed__17(int _003C_003E1__state)
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

		private EventHandler<TouchLayerEventArgs> pointerPressInvoker;

		public string Name;

		protected ProjectionParams layerProjectionParams;

		protected ILayerManager manager;

		private List<HitTest> tmpHitTestList;

		public virtual Vector3 WorldProjectionNormal => default;

		public ILayerDelegate Delegate { get; set; }

		public event EventHandler<TouchLayerEventArgs> PointerBegan
		{
			add
			{
			}
			remove
			{
			}
		}

		public virtual ProjectionParams GetProjectionParams(Pointer pointer)
		{
			return null;
		}

		public virtual HitResult Hit(IPointer pointer, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		protected virtual void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003ClateAwake_003Ed__17))]
		private IEnumerator lateAwake()
		{
			return null;
		}

		private void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		internal void INTERNAL_AddPointer(Pointer pointer)
		{
		}

		internal void INTERNAL_UpdatePointer(Pointer pointer)
		{
		}

		internal bool INTERNAL_PressPointer(Pointer pointer)
		{
			return false;
		}

		internal void INTERNAL_ReleasePointer(Pointer pointer)
		{
		}

		internal void INTERNAL_RemovePointer(Pointer pointer)
		{
		}

		internal void INTERNAL_CancelPointer(Pointer pointer)
		{
		}

		protected HitResult checkHitFilters(IPointer pointer, HitData hit)
		{
			return (HitResult)0;
		}

		protected virtual void setName()
		{
		}

		protected virtual void addPointer(Pointer pointer)
		{
		}

		protected virtual void pressPointer(Pointer pointer)
		{
		}

		protected virtual void updatePointer(Pointer pointer)
		{
		}

		protected virtual void releasePointer(Pointer pointer)
		{
		}

		protected virtual void removePointer(Pointer pointer)
		{
		}

		protected virtual void cancelPointer(Pointer pointer)
		{
		}

		protected virtual ProjectionParams createProjectionParams()
		{
			return null;
		}
	}
}
