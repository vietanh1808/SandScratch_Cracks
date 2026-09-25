using System.Collections.Generic;
using TouchScript.Gestures.TransformGestures.Base;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures.TransformGestures
{
	[AddComponentMenu("TouchScript/Gestures/Pinned Transform Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_TransformGestures_PinnedTransformGesture.htm")]
	public class PinnedTransformGesture : OnePointTrasformGestureBase
	{
		[SerializeField]
		private bool projectionProps;

		[SerializeField]
		private TransformGesture.ProjectionType projection;

		[SerializeField]
		private Vector3 projectionPlaneNormal;

		private TouchLayer projectionLayer;

		private Plane transformPlane;

		private CustomSampler gestureSampler;

		public TransformGesture.ProjectionType Projection
		{
			get
			{
				return TransformGesture.ProjectionType.Layer;
			}
			set
			{
			}
		}

		public Vector3 ProjectionPlaneNormal
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Plane TransformPlane => default;

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

		protected override float doRotation(Vector3 center, Vector2 oldScreenPos, Vector2 newScreenPos, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected override float doScaling(Vector3 center, Vector2 oldScreenPos, Vector2 newScreenPos, ProjectionParams projectionParams)
		{
			return 0f;
		}

		private void updateProjectionPlane()
		{
		}
	}
}
