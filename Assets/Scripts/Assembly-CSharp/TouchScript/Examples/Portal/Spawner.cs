using System;
using TouchScript.Gestures;
using UnityEngine;

namespace TouchScript.Examples.Portal
{
	public class Spawner : MonoBehaviour
	{
		public Transform Prefab;

		public Transform Position;

		private PressGesture press;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void pressHandler(object sender, EventArgs eventArgs)
		{
		}
	}
}
