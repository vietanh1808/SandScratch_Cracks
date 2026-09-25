using System;
using UnityEngine;

namespace TouchScript.Gestures.TransformGestures
{
	public interface ITransformGesture
	{
		TransformGesture.TransformType TransformMask { get; }

		Vector3 DeltaPosition { get; }

		float DeltaRotation { get; }

		float DeltaScale { get; }

		Vector3 RotationAxis { get; }

		event EventHandler<EventArgs> TransformStarted;

		event EventHandler<EventArgs> Transformed;

		event EventHandler<EventArgs> TransformCompleted;
	}
}
