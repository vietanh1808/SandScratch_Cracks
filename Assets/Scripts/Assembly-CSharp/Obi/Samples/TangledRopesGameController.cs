using UnityEngine;
using UnityEngine.Events;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class TangledRopesGameController : MonoBehaviour
	{
		public TangledPegSlot[] pegSlots;

		public float pegHoverHeight;

		public float maxPegDistanceFromSlot;

		public int framesWithoutContactsToWin;

		public UnityEvent onFinish;

		private TangledPeg selectedPeg;

		private Plane floor;

		private int framesSinceLastContact;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private TangledPegSlot FindCandidateSlot(TangledPeg peg)
		{
			return null;
		}

		private void Update()
		{
		}

		private void Solver_OnParticleCollision(ObiSolver s, ObiNativeContactList e)
		{
		}
	}
}
