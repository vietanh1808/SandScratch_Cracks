using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnTriggerEnter : DespawnerEvent
	{
		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
