using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class WorldSpaceGravity : MonoBehaviour
	{
		private ObiSolver solver;

		public Vector3 worldGravity;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
