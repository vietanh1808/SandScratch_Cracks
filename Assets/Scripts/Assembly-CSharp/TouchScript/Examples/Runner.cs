using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TouchScript.Layers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TouchScript.Examples
{
	public class Runner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CresetUILayer_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Runner _003C_003E4__this;

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
			public _003CresetUILayer_003Ed__9(int _003C_003E1__state)
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

		private static Runner instance;

		private TouchLayer layer;

		public void LoadLevel(string name)
		{
		}

		public void LoadNextLevel()
		{
		}

		public void LoadPreviousLevel()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void sceneLoadedHandler(Scene scene, LoadSceneMode mode)
		{
		}

		[IteratorStateMachine(typeof(_003CresetUILayer_003Ed__9))]
		private IEnumerator resetUILayer()
		{
			return null;
		}
	}
}
