using System;
using System.Collections.Generic;
using TouchScript.Pointers;
using TouchScript.Utils;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures
{
	[AddComponentMenu("TouchScript/Gestures/Flick Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_FlickGesture.htm")]
	public class FlickGesture : Gesture
	{
		public enum GestureDirection
		{
			Any = 0,
			Horizontal = 1,
			Vertical = 2
		}

		public const string FLICK_MESSAGE = "OnFlick";

		private EventHandler<EventArgs> flickedInvoker;

		[SerializeField]
		private float flickTime;

		[SerializeField]
		private float minDistance;

		[SerializeField]
		private float movementThreshold;

		[SerializeField]
		private GestureDirection direction;

		private bool moving;

		private Vector2 movementBuffer;

		private bool isActive;

		private TimedSequence<Vector2> deltaSequence;

		private CustomSampler gestureSampler;

		public float FlickTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MinDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MovementThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GestureDirection Direction
		{
			get
			{
				return GestureDirection.Any;
			}
			set
			{
			}
		}

		public Vector2 ScreenFlickVector { get; private set; }

		public float ScreenFlickTime { get; private set; }

		public event EventHandler<EventArgs> Flicked
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

		protected void LateUpdate()
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
	}
}
