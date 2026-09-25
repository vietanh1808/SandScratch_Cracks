using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(Rigidbody))]
	public class TangledPeg : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveTowardsSlot_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TangledPeg _003C_003E4__this;

			public TangledPegSlot slot;

			private float _003Cdistance_003E5__2;

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
			public _003CMoveTowardsSlot_003Ed__19(int _003C_003E1__state)
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

		public TangledPegSlot currentSlot;

		public Collider floorCollider;

		public ObiRope attachedRope;

		[Header("Movement")]
		public float stiffness;

		public float damping;

		public float maxAccel;

		public float minDistance;

		public Rigidbody rb { get; private set; }

		public ObiRigidbody orb { get; private set; }

		private void Awake()
		{
		}

		public float MoveTowards(Vector3 position)
		{
			return 0f;
		}

		public void DockInSlot(TangledPegSlot slot)
		{
		}

		public void UndockFromCurrentSlot()
		{
		}

		[IteratorStateMachine(typeof(_003CMoveTowardsSlot_003Ed__19))]
		private IEnumerator MoveTowardsSlot(TangledPegSlot slot)
		{
			return null;
		}
	}
}
