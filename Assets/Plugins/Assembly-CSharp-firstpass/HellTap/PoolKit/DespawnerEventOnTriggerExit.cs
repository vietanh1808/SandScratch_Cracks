using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnTriggerExit : DespawnerEvent
	{
		private void OnTriggerExit(Collider other)
		{
		}
	}
}
