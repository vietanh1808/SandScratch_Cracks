using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TouchScript.Pointers;
using TouchScript.Utils;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures
{
	[AddComponentMenu("TouchScript/Gestures/Tap Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_TapGesture.htm")]
	public class TapGesture : Gesture
	{
		[CompilerGenerated]
		private sealed class _003Cwait_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TapGesture _003C_003E4__this;

			private float _003CtargetTime_003E5__2;

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
			public _003Cwait_003Ed__43(int _003C_003E1__state)
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

		public const string TAP_MESSAGE = "OnTap";

		private EventHandler<EventArgs> tappedInvoker;

		public GestureEvent OnTap;

		[SerializeField]
		private int numberOfTapsRequired;

		[SerializeField]
		[NullToggle(NullFloatValue = 1f / 0f)]
		private float timeLimit;

		[SerializeField]
		[NullToggle(NullFloatValue = 1f / 0f)]
		private float distanceLimit;

		[SerializeField]
		[ToggleLeft]
		private bool combinePointers;

		[SerializeField]
		private float combinePointersInterval;

		private float distanceLimitInPixelsSquared;

		private bool isActive;

		private int tapsDone;

		private Vector2 startPosition;

		private Vector2 totalMovement;

		private TimedSequence<Pointer> pointerSequence;

		private CustomSampler gestureSampler;

		public int NumberOfTapsRequired
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float TimeLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float DistanceLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool CombinePointers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CombinePointersInterval
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event EventHandler<EventArgs> Tapped
		{
			add
			{
			}
			remove
			{
			}
		}

		public override bool ShouldReceivePointer(Pointer pointer)
		{
			return false;
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		[ContextMenu("Basic Editor")]
		private void switchToBasicEditor()
		{
		}

		protected override void pointersPressed(IList<Pointer> pointers)
		{
		}

		protected override void pointersUpdated(IList<Pointer> pointers)
		{
		}

		protected override void pointersReleased(IList<Pointer> pointers)
		{
		}

		protected override void onRecognized()
		{
		}

		protected override void reset()
		{
		}

		protected override bool shouldCachePointerPosition(Pointer value)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003Cwait_003Ed__43))]
		private IEnumerator wait()
		{
			return null;
		}
	}
}
