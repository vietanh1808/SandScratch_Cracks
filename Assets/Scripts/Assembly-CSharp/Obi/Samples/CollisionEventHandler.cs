using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class CollisionEventHandler : MonoBehaviour
	{
		private ObiSolver solver;

		public int contactCount;

		private ObiNativeContactList frame;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Solver_OnCollision(object sender, ObiNativeContactList e)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
