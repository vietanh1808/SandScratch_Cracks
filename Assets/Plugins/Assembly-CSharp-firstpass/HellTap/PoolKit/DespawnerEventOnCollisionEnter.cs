using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnCollisionEnter : DespawnerEvent
	{
		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
