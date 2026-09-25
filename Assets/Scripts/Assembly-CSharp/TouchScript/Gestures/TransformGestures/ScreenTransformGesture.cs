using System.Collections.Generic;
using TouchScript.Gestures.TransformGestures.Base;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures.TransformGestures
{
	[AddComponentMenu("TouchScript/Gestures/Screen Transform Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_TransformGestures_ScreenTransformGesture.htm")]
	public class ScreenTransformGesture : TwoPointTransformGestureBase
	{
		private CustomSampler gestureSampler;

		protected override void Awake()
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

		private Vector2 scaleAndRotate(Vector2 point, Vector2 center, float dR, float dS)
		{
			return default;
		}
	}
}
