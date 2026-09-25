using System;
using TouchScript.Gestures;
using UnityEngine;

namespace TouchScript.Examples.Tap
{
	public class Kick : MonoBehaviour
	{
		public float Force;

		public ParticleSystem Particles;

		private TapGesture gesture;

		private Rigidbody rb;

		private Camera activeCamera;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void tappedHandler(object sender, EventArgs e)
		{
		}
	}
}
