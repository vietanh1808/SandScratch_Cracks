using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;
using Obi;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class IngameObiRope : JMonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTeleportParticlesToHooks_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IngameObiRope _003C_003E4__this;

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
			public _003CTeleportParticlesToHooks_003Ed__23(int _003C_003E1__state)
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

		[Header("Hook Points")]
		[SerializeField]
		private Transform hookA;

		[SerializeField]
		private Transform hookB;

		[SerializeField]
		private Transform hookHeadA;

		[SerializeField]
		private Transform hookHeadB;

		[Header("Length Control")]
		[SerializeField]
		[Tooltip("Hệ số chùng khi gần nhau: restLength = slackDistance * slackRatio")]
		private float slackRatio;

		[SerializeField]
		private float retractSpeed;

		[SerializeField]
		private float extendSpeed;

		public ObiRope rope;

		public ObiRopeCursor cursor;

		public ObiRopeBlueprint blueprint;

		public ObiRopeExtrudedRenderer extrudedRenderer;

		private bool isSetupAlready;

		private float hookALocalYOffset;

		private float hookBLocalYOffset;

		public bool IsReady => false;

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void SetPool()
		{
		}

		private void UpdateRopeLength()
		{
		}

		internal void Setup(Material material)
		{
		}

		internal void Setup()
		{
		}

		private void RotateHooksToFaceEachOther()
		{
		}

		[IteratorStateMachine(typeof(_003CTeleportParticlesToHooks_003Ed__23))]
		private IEnumerator TeleportParticlesToHooks()
		{
			return null;
		}

		private void RebindHookAttachments()
		{
		}

		public void FreezeForRelease()
		{
		}
	}
}
