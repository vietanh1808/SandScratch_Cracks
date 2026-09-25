using System.Collections.Generic;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Gestures.TransformGestures.Base
{
	public abstract class OnePointTrasformGestureBase : TransformGestureBase
	{
		protected Vector2 screenPixelTranslationBuffer;

		protected float screenPixelRotationBuffer;

		protected float angleBuffer;

		protected float screenPixelScalingBuffer;

		protected float scaleBuffer;

		public override Vector2 ScreenPosition => default;

		public override Vector2 PreviousScreenPosition => default;

		protected override void pointersUpdated(IList<Pointer> pointers)
		{
		}

		protected override void reset()
		{
		}

		protected virtual float doRotation(Vector3 center, Vector2 oldScreenPos, Vector2 newScreenPos, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected virtual float doScaling(Vector3 center, Vector2 oldScreenPos, Vector2 newScreenPos, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected virtual bool relevantPointers(IList<Pointer> pointers)
		{
			return false;
		}

		protected virtual Vector2 getPointScreenPosition()
		{
			return default;
		}

		protected virtual Vector2 getPointPreviousScreenPosition()
		{
			return default;
		}

		protected override void updateType()
		{
		}
	}
}
