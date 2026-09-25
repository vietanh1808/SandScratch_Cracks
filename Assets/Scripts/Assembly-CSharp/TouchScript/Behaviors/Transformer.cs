using System;
using TouchScript.Gestures;
using TouchScript.Gestures.TransformGestures;
using TouchScript.Gestures.TransformGestures.Base;
using TouchScript.Utils.Attributes;
using UnityEngine;

namespace TouchScript.Behaviors
{
	[AddComponentMenu("TouchScript/Behaviors/Transformer")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Transformer.htm")]
	public class Transformer : MonoBehaviour
	{
		private enum TransformerState
		{
			Idle = 0,
			Manual = 1,
			Automatic = 2
		}

		[SerializeField]
		[ToggleLeft]
		private bool enableSmoothing;

		[SerializeField]
		private float smoothingFactor;

		[SerializeField]
		private float positionThreshold;

		[SerializeField]
		private float rotationThreshold;

		[SerializeField]
		private float scaleThreshold;

		[SerializeField]
		[ToggleLeft]
		private bool allowChangingFromOutside;

		private TransformerState state;

		private TransformGestureBase gesture;

		private Transform cachedTransform;

		private TransformGesture.TransformType transformMask;

		private Vector3 targetPosition;

		private Vector3 targetScale;

		private Quaternion targetRotation;

		private Vector3 lastPosition;

		private Vector3 lastScale;

		private Quaternion lastRotation;

		public bool EnableSmoothing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SmoothingFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PositionThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RotationThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool AllowChangingFromOutside
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void stateIdle()
		{
		}

		private void stateManual()
		{
		}

		private void stateAutomatic()
		{
		}

		private void setState(TransformerState newState)
		{
		}

		private void update()
		{
		}

		private void manualUpdate()
		{
		}

		private void applyValues()
		{
		}

		private void stateChangedHandler(object sender, GestureStateChangeEventArgs gestureStateChangeEventArgs)
		{
		}

		private void frameFinishedHandler(object sender, EventArgs eventArgs)
		{
		}
	}
}
