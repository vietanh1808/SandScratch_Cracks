using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnCollision2DExit : DespawnerEvent
	{
		private ContactPoint2D[] _cachedContacts;

		private void OnCollisionExit2D(Collision2D collision)
		{
		}
	}
}
