using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Obi.Samples
{
	public class GrapplingHook : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAttachHook_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GrapplingHook _003C_003E4__this;

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
			public _003CAttachHook_003Ed__13(int _003C_003E1__state)
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

		public float hookExtendRetractSpeed;

		public Material material;

		public ObiRopeSection section;

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

		[IteratorStateMachine(typeof(_003CAttachHook_003Ed__13))]
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
