using System;
using TouchScript.Gestures.TransformGestures;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class CinemachineCamController : ACinemachineCamController
	{
		[SerializeField]
		private ScreenTransformGesture OneFingerMoveGesture;

		[SerializeField]
		private ScreenTransformGesture TwoFingerMoveGesture;

		[SerializeField]
		private float panSpeed;

		[SerializeField]
		private float zoomSpeed;

		private Transform pivot => null;

		protected override string LogName => null;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OneFingerMoveTransformedHandler(object sender, EventArgs e)
		{
		}

		private void HandlePan()
		{
		}

		private void TwoFingerTransformHandler(object sender, EventArgs e)
		{
		}

		private void HandleZoom()
		{
		}
	}
}
