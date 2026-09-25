using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class RopeBehaviour : ARopeBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnSetup_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RopeBehaviour _003C_003E4__this;

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
			public _003COnSetup_003Ed__22(int _003C_003E1__state)
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

		public Transform hookA;

		public Transform hookB;

		public float releaseSpeed;

		public float fallDistance;

		public float fallDuration;

		public Ease fallEase;

		public IngameObiRope rope;

		public Material sampleRopeMat;

		public MeshRenderer[] hookMeshA;

		public MeshRenderer[] hookMeshB;

		public IngameRopeData data;

		private Action OnSetupAction;

		private TweenerCore<Vector3, Vector3, VectorOptions> tweenRelease;

		private Material ropeMat;

		private void ReloadScene()
		{
		}

		public override void SetPooling()
		{
		}

		public override void Relase(Action onDone)
		{
		}

		public void ReleaseFalling(Action onDone)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void RemoveAllPhysics()
		{
		}

		private void EnableAllPhysics()
		{
		}

		public override void Setup((Transform parent, Vector3 localPos) itemA, (Transform parent, Vector3 localPos) itemB)
		{
		}

		[IteratorStateMachine(typeof(_003COnSetup_003Ed__22))]
		private IEnumerator OnSetup()
		{
			return null;
		}

		private void Test()
		{
		}

		public override void Setup(Color colorA, Color colorB)
		{
		}

		public override void Test(GameObjectColor objColorA, GameObjectColor objColorB)
		{
		}

		public override void Setup(GameObjectColor objColorA, GameObjectColor objColorB)
		{
		}
	}
}
