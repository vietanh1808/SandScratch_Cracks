using UnityEngine;
using UnityEngine.Events;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiSolver))]
	public class ActorActorCollisionDetector : MonoBehaviour
	{
		public struct ActorPair
		{
			public readonly ObiActor actorA;

			public readonly ObiActor actorB;

			public int particleA;

			public int particleB;

			public ActorPair(ObiActor actorA, ObiActor actorB, int particleA, int particleB)
			{
				this.actorA = null;
				this.actorB = null;
				this.particleA = 0;
				this.particleB = 0;
			}
		}

		public UnityEvent<ActorPair> callback;

		private ObiSolver solver;

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
