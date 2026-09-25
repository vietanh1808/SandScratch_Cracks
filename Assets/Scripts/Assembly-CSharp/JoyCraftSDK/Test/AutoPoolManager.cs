using System.Collections.Generic;
using HellTap.PoolKit;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class AutoPoolManager : JMonoBehaviour
	{
		[Header("Default Settings")]
		[SerializeField]
		private int defaultPoolSize;

		[SerializeField]
		private bool enablePoolProtection;

		[SerializeField]
		private bool logPoolCreation;

		private readonly Dictionary<GameObject, Pool> prefabToPool;

		private readonly Dictionary<int, GameObject> instanceIdToPrefab;

		public static AutoPoolManager Instance { get; private set; }

		public override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public GameObject Spawn(GameObject prefab, Vector3 position, Transform parent = null)
		{
			return null;
		}

		public GameObject Spawn(GameObject prefab, Transform spawnPoint, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnLocal(GameObject prefab, Vector3 localPosition, Quaternion localRotation, Transform parent)
		{
			return null;
		}

		public void Despawn(GameObject instance)
		{
		}

		public void Despawn(GameObject instance, float delay)
		{
		}

		public void DespawnAll(GameObject prefab)
		{
		}

		public void DespawnAll()
		{
		}

		public void Prewarm(GameObject prefab, int count = -1)
		{
		}

		public void Prewarm(IEnumerable<GameObject> prefabs, int countEach = -1)
		{
		}

		public bool HasPool(GameObject prefab)
		{
			return false;
		}

		public int GetActiveCount(GameObject prefab)
		{
			return 0;
		}

		public int GetAvailableCount(GameObject prefab)
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
