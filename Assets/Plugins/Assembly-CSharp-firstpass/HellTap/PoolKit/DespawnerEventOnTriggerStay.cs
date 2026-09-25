using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnTriggerStay : DespawnerEvent
	{
		private void OnTriggerStay(Collider other)
		{
		}
	}
}
