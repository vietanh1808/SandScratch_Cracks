using UnityEngine;

namespace Obi.Samples
{
	public class ActorSpawner : MonoBehaviour
	{
		public ObiActor template;

		public int maxInstances;

		public float spawnDelay;

		private int instances;

		private float timeFromLastSpawn;

		private void Update()
		{
		}
	}
}
