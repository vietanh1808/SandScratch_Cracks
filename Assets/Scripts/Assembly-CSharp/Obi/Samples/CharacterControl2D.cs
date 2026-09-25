using UnityEngine;

namespace Obi.Samples
{
	public class CharacterControl2D : MonoBehaviour
	{
		public float floorRaycastDistance;

		[Header("Grounded")]
		public float acceleration;

		public float maxSpeed;

		public float damping;

		public float jumpPower;

		[Header("Airborne")]
		public float airAcceleration;

		public float airMaxSpeed;

		public float extraGravity;

		[Header("Auto upright")]
		public Vector3 centerOfMass;

		public float P;

		public float D;

		private Rigidbody unityRigidbody;

		private float axis;

		private bool grounded;

		private float error;

		private float prevError;

		public void Awake()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
