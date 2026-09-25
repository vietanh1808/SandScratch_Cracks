using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures
{
	[AddComponentMenu("TouchScript/Gestures/Long Press Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_LongPressGesture.htm")]
	public class LongPressGesture : Gesture
	{
		[CompilerGenerated]
		private sealed class _003Cwait_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LongPressGesture _003C_003E4__this;

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
			public _003Cwait_003Ed__25(int _003C_003E1__state)
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

		public const string LONG_PRESS_MESSAGE = "OnLongPress";

		private EventHandler<EventArgs> longPressedInvoker;

		public GestureEvent OnLongPress;

		[SerializeField]
		private float timeToPress;

		[SerializeField]
		[NullToggle(NullFloatValue = 1f / 0f)]
		private float distanceLimit;

		private float distanceLimitInPixelsSquared;

		private Vector2 totalMovement;

		private CustomSampler gestureSampler;

		public float TimeToPress
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

		public event EventHandler<EventArgs> LongPressed
		{
			add
			{
			}
			remove
			{
			}
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

		[IteratorStateMachine(typeof(_003Cwait_003Ed__25))]
		private IEnumerator wait()
		{
			return null;
		}
	}
}
