using System.Collections.Generic;
using HellTap.PoolKit;
using UnityEngine;

namespace JoyCraftSDK
{
	public class PoolManager : APoolManager
	{
		[Header("Default Settings")]
		[SerializeField]
		private int defaultPoolSize;

		[SerializeField]
		private PoolInput poolInput;

		[SerializeField]
		private bool enablePoolProtection;

		[SerializeField]
		private bool logPoolCreation;

		private readonly Dictionary<GameObject, Pool> prefabToPool;

		public override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public override GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public override GameObject Spawn(GameObject prefab, Vector3 position, Transform parent = null)
		{
			return null;
		}

		public override GameObject SpawnLocal(GameObject prefab, Vector3 localPosition, Quaternion localRotation, Transform parent)
		{
			return null;
		}

		public override void Despawn(GameObject instance)
		{
		}

		public override void Despawn(GameObject instance, float delay)
		{
		}

		public override void DespawnAll(GameObject prefab)
		{
		}

		public override void DespawnAll()
		{
		}

		public override void Prewarm(GameObject prefab, int count = -1)
		{
		}

		public override void Prewarm(IEnumerable<GameObject> prefabs, int countEach = -1)
		{
		}

		public bool HasPool(GameObject prefab)
		{
			return false;
		}

		public override int GetActiveCount(GameObject prefab)
		{
			return 0;
		}

		public override int GetAvailableCount(GameObject prefab)
		{
			return 0;
		}

		private Pool GetOrCreatePool(GameObject prefab)
		{
			return null;
		}

		private Pool CreatePool(GameObject prefab, int poolSize)
		{
			return null;
		}
	}
}
