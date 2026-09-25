using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnTrigger2DEnter : DespawnerEvent
	{
		private void OnTriggerEnter2D(Collider2D other)
		{
		}
	}
}
