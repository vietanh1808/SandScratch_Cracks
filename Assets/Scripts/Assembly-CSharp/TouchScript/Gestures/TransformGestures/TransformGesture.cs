using System;
using System.Collections.Generic;
using TouchScript.Gestures.TransformGestures.Base;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures.TransformGestures
{
	[AddComponentMenu("TouchScript/Gestures/Transform Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_TransformGestures_TransformGesture.htm")]
	public class TransformGesture : TwoPointTransformGestureBase
	{
		[Flags]
		public enum TransformType
		{
			None = 0,
			Translation = 1,
			Rotation = 2,
			Scaling = 4
		}

		public enum ProjectionType
		{
			Layer = 0,
			Object = 1,
			Global = 2
		}

		[SerializeField]
		private bool projectionProps;

		[SerializeField]
		private ProjectionType projection;

		[SerializeField]
		private Vector3 projectionPlaneNormal;

		private TouchLayer projectionLayer;

		private Plane transformPlane;

		private CustomSampler gestureSampler;

		public ProjectionType Projection
		{
			get
			{
				return ProjectionType.Layer;
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

		public Vector3 LocalDeltaPosition => default;

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

		protected Vector3 projectScaledRotated(Vector2 point, float dR, float dS, ProjectionParams projectionParams)
		{
			return default;
		}

		protected override float doRotation(Vector2 oldScreenPos1, Vector2 oldScreenPos2, Vector2 newScreenPos1, Vector2 newScreenPos2, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected override float doScaling(Vector2 oldScreenPos1, Vector2 oldScreenPos2, Vector2 newScreenPos1, Vector2 newScreenPos2, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected override Vector3 doOnePointTranslation(Vector2 oldScreenPos, Vector2 newScreenPos, ProjectionParams projectionParams)
		{
			return default;
		}

		protected override Vector3 doTwoPointTranslation(Vector2 oldScreenPos1, Vector2 oldScreenPos2, Vector2 newScreenPos1, Vector2 newScreenPos2, float dR, float dS, ProjectionParams projectionParams)
		{
			return default;
		}

		private void updateProjectionPlane()
		{
		}
	}
}
