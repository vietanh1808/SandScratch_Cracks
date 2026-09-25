using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class ColliderHighlighter : MonoBehaviour
	{
		private ObiSolver solver;

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
