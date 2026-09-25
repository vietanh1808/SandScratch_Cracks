using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	public class JTutorialController : ATutorialController
	{
		[CompilerGenerated]
		private sealed class _003CRunStep_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JTutorialController _003C_003E4__this;

			public TutorialStep step;

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
			public _003CRunStep_003Ed__15(int _003C_003E1__state)
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

		[FormerlySerializedAs("data")]
		[SerializeField]
		private JTutorialMainData tutorialMainData;

		private TutorialFlow flow;

		private int stepIndex;

		private IStep curUiStep;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void StopCurrent()
		{
		}

		public override TutorialFlow GetFlowForLevel(int level)
		{
			return null;
		}

		private TutorialFlow FindFlow(Func<TutorialFlow, bool> match)
		{
			return null;
		}

		private void GetLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		public override void Play(TutorialFlow flow)
		{
		}

		public override void Play()
		{
		}

		public override void Play(TutorialType type)
		{
		}

		private void NextStep()
		{
		}

		private void GenerateUIStep(GameObject pb, TutorialStep step)
		{
		}

		[IteratorStateMachine(typeof(_003CRunStep_003Ed__15))]
		private IEnumerator RunStep(TutorialStep step)
		{
			return null;
		}

		public void FinishTutorial()
		{
		}

		public void SetCompleteCurrent()
		{
		}

		public override void SetCompleteAll()
		{
		}
	}
}
