using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnCollision2DStay : DespawnerEvent
	{
		private ContactPoint2D[] _cachedContacts;

		private void OnCollisionStay2D(Collision2D collision)
		{
		}
	}
}
