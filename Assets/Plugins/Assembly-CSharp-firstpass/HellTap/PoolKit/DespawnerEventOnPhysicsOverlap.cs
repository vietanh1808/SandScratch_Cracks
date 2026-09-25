using UnityEngine;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class DespawnerEventOnPhysicsOverlap : DespawnerEvent
	{
		private Transform m_Transform;

		private Collider[] _resultsBuffer;

		private Collider2D[] _resultsBuffer2D;

		private int m_HitDetect;

		private bool using2D;

		private Vector3 liveScale;

		private ContactFilter2D _contactFilter;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
