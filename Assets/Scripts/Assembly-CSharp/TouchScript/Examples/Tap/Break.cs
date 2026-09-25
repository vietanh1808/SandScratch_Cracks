using System;
using TouchScript.Gestures;
using UnityEngine;

namespace TouchScript.Examples.Tap
{
	public class Break : MonoBehaviour
	{
		public float Power;

		private LongPressGesture longPressGesture;

		private PressGesture pressGesture;

		private MeshRenderer rnd;

		private bool growing;

		private float growingTime;

		private Vector3[] directions;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void startGrowing()
		{
		}

		private void stopGrowing()
		{
		}

		private void pressedHandler(object sender, EventArgs e)
		{
		}

		private void longPressedHandler(object sender, GestureStateChangeEventArgs e)
		{
		}
	}
}
