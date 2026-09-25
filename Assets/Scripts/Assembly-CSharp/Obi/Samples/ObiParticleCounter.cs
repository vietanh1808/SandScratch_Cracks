using System.Collections.Generic;
using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class ObiParticleCounter : MonoBehaviour
	{
		private ObiSolver solver;

		public int counter;

		public Collider2D targetCollider;

		private ObiNativeContactList frame;

		private HashSet<int> particles;

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
	}
}
