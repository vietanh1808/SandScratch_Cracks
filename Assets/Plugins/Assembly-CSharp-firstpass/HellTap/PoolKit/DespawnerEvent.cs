using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEvent : MonoBehaviour
	{
		public Despawner despawner;

		private bool hasStarted;

		private void Start()
		{
		}
	}
}
