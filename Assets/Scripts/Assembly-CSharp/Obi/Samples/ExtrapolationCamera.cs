using UnityEngine;

namespace Obi.Samples
{
	public class ExtrapolationCamera : MonoBehaviour
	{
		public Transform target;

		public float extrapolation;

		[Range(0f, 1f)]
		public float smoothness;

		[Range(0f, 1f)]
		public float linearSpeed;

		[Range(0f, 1f)]
		public float rotationalSpeed;

		[Min(0f)]
		public float distanceFromTarget;

		private Vector3 lastPosition;

		private Vector3 extrapolatedPos;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation)
		{
		}
	}
}
