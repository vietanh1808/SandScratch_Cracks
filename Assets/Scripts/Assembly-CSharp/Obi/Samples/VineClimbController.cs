using UnityEngine;

namespace Obi.Samples
{
	public class VineClimbController : MonoBehaviour
	{
		public ObiSolver solver;

		public float climbSpeed;

		private ObiPinhole pinhole;

		private bool pressedSpace;

		private void Start()
		{
		}

		public void Update()
		{
		}

		private void Solver_OnCollision(ObiSolver solver, ObiNativeContactList contacts)
		{
		}

		private float GetParticleMu(ObiRope rope, int solverParticleIndex)
		{
			return 0f;
		}

		private void AttachToVine(ObiRope rope, int particle, Vector3 offset)
		{
		}

		private void DetachFromVine()
		{
		}
	}
}
