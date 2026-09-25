using System;
using UnityEngine;

namespace TouchScript.Examples.Portal
{
	public class Planet : MonoBehaviour
	{
		private enum PlanetStatus
		{
			Free = 0,
			Manual = 1,
			Falling = 2
		}

		public float Speed;

		public float RotationSpeed;

		public float FallSpeed;

		private PlanetStatus status;

		public void Fall()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void pressedhandler(object sender, EventArgs e)
		{
		}

		private void releasedHandler(object sender, EventArgs e)
		{
		}
	}
}
