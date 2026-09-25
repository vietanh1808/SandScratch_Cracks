using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnCollision2DEnter : DespawnerEvent
	{
		private ContactPoint2D[] _cachedContacts;

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}
	}
}
