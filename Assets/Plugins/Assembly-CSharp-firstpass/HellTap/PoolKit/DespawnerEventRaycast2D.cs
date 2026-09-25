using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventRaycast2D : DespawnerEvent
	{
		internal RaycastHit2D[] _raycastHitResults;

		private int _numberOfRaycastHits;

		private ContactFilter2D _contactFilter;

		private void Update()
		{
		}
	}
}
