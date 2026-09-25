using System;
using TouchScript.Gestures.TransformGestures;
using UnityEngine;

namespace TouchScript.Examples.CameraControl
{
	public class CameraController : MonoBehaviour
	{
		public ScreenTransformGesture TwoFingerMoveGesture;

		public ScreenTransformGesture ManipulationGesture;

		public float PanSpeed;

		public float RotationSpeed;

		public float ZoomSpeed;

		private Transform pivot;

		private Transform cam;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void manipulationTransformedHandler(object sender, EventArgs e)
		{
		}

		private void twoFingerTransformHandler(object sender, EventArgs e)
		{
		}
	}
}
