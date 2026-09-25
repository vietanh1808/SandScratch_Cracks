using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnCollisionExit : DespawnerEvent
	{
		private void OnCollisionExit(Collision collision)
		{
		}
	}
}
