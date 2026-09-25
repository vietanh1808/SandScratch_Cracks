using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Obi.Samples
{
	public class ExtendableGrapplingHook : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAttachHook_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtendableGrapplingHook _003C_003E4__this;

			private ObiConstraints<ObiPinConstraintsBatch> _003CpinConstraints_003E5__2;

			private Vector3 _003Corigin_003E5__3;

			private Vector3 _003Cdirection_003E5__4;

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
			public _003CAttachHook_003Ed__17(int _003C_003E1__state)
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

		public ObiSolver solver;

		public ObiCollider character;

		public Material material;

		public ObiRopeSection section;

		[Range(0f, 1f)]
		public float hookResolution;

		public float hookExtendRetractSpeed;

		public float hookShootSpeed;

		public int particlePoolSize;

		private ObiRope rope;

		private ObiRopeBlueprint blueprint;

		private ObiRopeExtrudedRenderer ropeRenderer;

		private ObiRopeCursor cursor;

		private RaycastHit hookAttachment;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void LaunchHook()
		{
		}

		private void LayParticlesInStraightLine(Vector3 origin, Vector3 direction)
		{
		}

		[IteratorStateMachine(typeof(_003CAttachHook_003Ed__17))]
		private IEnumerator AttachHook()
		{
			return null;
		}

		private void DetachHook()
		{
		}

		private void Update()
		{
		}
	}
}
