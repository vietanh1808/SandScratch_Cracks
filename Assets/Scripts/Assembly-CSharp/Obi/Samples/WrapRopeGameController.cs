using UnityEngine;
using UnityEngine.Events;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class WrapRopeGameController : MonoBehaviour
	{
		private ObiSolver solver;

		public Wrappable[] wrappables;

		public UnityEvent onFinish;

		private void Awake()
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

		private void Solver_OnCollision(ObiSolver s, ObiNativeContactList e)
		{
		}
	}
}
