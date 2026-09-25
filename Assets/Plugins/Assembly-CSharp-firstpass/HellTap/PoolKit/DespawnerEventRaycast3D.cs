using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventRaycast3D : DespawnerEvent
	{
		internal RaycastHit[] _raycastHitResults;

		private int _numberOfRaycastHits;

		private void Update()
		{
		}
	}
}
