using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnTrigger2DStay : DespawnerEvent
	{
		private void OnTriggerStay2D(Collider2D other)
		{
		}
	}
}
