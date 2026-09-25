using System;
using System.Collections.Generic;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Gestures.TransformGestures.Base
{
	public abstract class TransformGestureBase : Gesture, ITransformGesture
	{
		public const string TRANSFORM_START_MESSAGE = "OnTransformStart";

		public const string TRANSFORM_MESSAGE = "OnTransform";

		public const string TRANSFORM_COMPLETE_MESSAGE = "OnTransformComplete";

		private EventHandler<EventArgs> transformStartedInvoker;

		private EventHandler<EventArgs> transformedInvoker;

		private EventHandler<EventArgs> transformCompletedInvoker;

		public GestureEvent OnTransformStart;

		public GestureEvent OnTransform;

		public GestureEvent OnTransformComplete;

		protected float screenTransformPixelThreshold;

		protected float screenTransformPixelThresholdSquared;

		protected TransformGesture.TransformType transformMask;

		protected Vector3 deltaPosition;

		protected float deltaRotation;

		protected float deltaScale;

		protected Vector3 rotationAxis;

		protected bool isTransforming;

		protected bool targetPositionOverridden;

		protected Vector3 targetPosition;

		[SerializeField]
		protected TransformGesture.TransformType type;

		[SerializeField]
		private float screenTransformThreshold;

		public TransformGesture.TransformType Type
		{
			get
			{
				return TransformGesture.TransformType.None;
			}
			set
			{
			}
		}

		public float ScreenTransformThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TransformGesture.TransformType TransformMask => TransformGesture.TransformType.None;

		public Vector3 DeltaPosition => default;

		public float DeltaRotation => 0f;

		public float DeltaScale => 0f;

		public Vector3 RotationAxis => default;

		public event EventHandler<EventArgs> TransformStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> Transformed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> TransformCompleted
		{
			add
			{
			}
			remove
			{
			}
		}

		public void OverrideTargetPosition(Vector3 position)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void pointersPressed(IList<Pointer> pointers)
		{
		}

		protected override void pointersReleased(IList<Pointer> pointers)
		{
		}

		protected override void onBegan()
		{
		}

		protected override void onChanged()
		{
		}

		protected override void onRecognized()
		{
		}

		protected override void reset()
		{
		}

		protected virtual void updateType()
		{
		}

		protected void resetValues()
		{
		}

		private void updateScreenTransformThreshold()
		{
		}
	}
}
