using System.Collections.Generic;
using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Gestures.TransformGestures.Base
{
	public abstract class TwoPointTransformGestureBase : TransformGestureBase
	{
		protected float minScreenPointsPixelDistance;

		protected float minScreenPointsPixelDistanceSquared;

		protected Vector2 screenPixelTranslationBuffer;

		protected float screenPixelRotationBuffer;

		protected float angleBuffer;

		protected float screenPixelScalingBuffer;

		protected float scaleBuffer;

		[SerializeField]
		private float minScreenPointsDistance;

		public virtual float MinScreenPointsDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void pointersUpdated(IList<Pointer> pointers)
		{
		}

		protected override void reset()
		{
		}

		protected virtual float doRotation(Vector2 oldScreenPos1, Vector2 oldScreenPos2, Vector2 newScreenPos1, Vector2 newScreenPos2, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected virtual float doScaling(Vector2 oldScreenPos1, Vector2 oldScreenPos2, Vector2 newScreenPos1, Vector2 newScreenPos2, ProjectionParams projectionParams)
		{
			return 0f;
		}

		protected virtual Vector3 doOnePointTranslation(Vector2 oldScreenPos, Vector2 newScreenPos, ProjectionParams projectionParams)
		{
			return default;
		}

		protected virtual Vector3 doTwoPointTranslation(Vector2 oldScreenPos1, Vector2 oldScreenPos2, Vector2 newScreenPos1, Vector2 newScreenPos2, float dR, float dS, ProjectionParams projectionParams)
		{
			return default;
		}

		protected virtual int getNumPoints()
		{
			return 0;
		}

		protected virtual bool relevantPointers1(IList<Pointer> pointers)
		{
			return false;
		}

		protected virtual bool relevantPointers2(IList<Pointer> pointers)
		{
			return false;
		}

		protected virtual Vector2 getPointScreenPosition(int index)
		{
			return default;
		}

		protected virtual Vector2 getPointPreviousScreenPosition(int index)
		{
			return default;
		}

		private void updateMinScreenPointsDistance()
		{
		}
	}
}
