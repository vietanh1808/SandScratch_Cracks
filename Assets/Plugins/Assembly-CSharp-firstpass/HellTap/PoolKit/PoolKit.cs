using UnityEngine;

namespace HellTap.PoolKit
{
	public static class PoolKit
	{
		public enum RenameFormat
		{
			EasyToReadObjectNameWithPoolKitAndIndex = 0,
			EasyToReadObjectNameWithIndex = 1,
			ObjectNameWithPoolKitAndIndex = 2,
			ObjectNameWithIndex = 3,
			NoRenaming = 4
		}

		public delegate GameObject CreateInstanceDelegate(GameObject prefab);

		public delegate void DestroyInstanceDelegate(GameObject instance);

		public static RenameFormat renameObjectsInPool;

		public static bool onlyRenameObjectsInEditor;

		public static Pool[] pools;

		public static Spawner[] spawners;

		public static bool debugPoolKit;

		private static bool _createdGlobalPools;

		private static Pool[] allPoolsInScene;

		private static Spawner[] allSpawnersInScene;

		public static CreateInstanceDelegate OnCreateInstance;

		public static DestroyInstanceDelegate OnDestroyInstance;

		[RuntimeInitializeOnLoadMethod]
		public static void CreateGlobalPools()
		{
		}

		internal static void RegisterPool(Pool pool)
		{
		}

		internal static void UnregisterPool(Pool pool)
		{
		}

		public static bool PoolExists(string poolName)
		{
			return false;
		}

		public static Pool Find(string poolName)
		{
			return null;
		}

		public static Pool FindPool(string poolName)
		{
			return null;
		}

		public static Pool GetPool(string poolName)
		{
			return null;
		}

		public static Pool FindPoolContainingPrefab(string prefabName)
		{
			return null;
		}

		public static Pool GetPoolContainingPrefab(string prefabName)
		{
			return null;
		}

		public static Pool FindPoolContainingPrefab(Transform prefab)
		{
			return null;
		}

		public static Pool GetPoolContainingPrefab(Transform prefab)
		{
			return null;
		}

		public static Pool FindPoolContainingPrefab(GameObject prefab)
		{
			return null;
		}

		public static Pool GetPoolContainingPrefab(GameObject prefab)
		{
			return null;
		}

		public static Pool FindPoolContainingInstance(Transform instance)
		{
			return null;
		}

		public static Pool GetPoolContainingInstance(Transform instance)
		{
			return null;
		}

		public static Pool FindPoolContainingInstance(GameObject instance)
		{
			return null;
		}

		public static Pool GetPoolContainingInstance(GameObject instance)
		{
			return null;
		}

		internal static void RegisterSpawner(Spawner spawner)
		{
		}

		internal static void UnregisterSpawner(Spawner spawner)
		{
		}

		public static Spawner FindSpawner(string spawnerName)
		{
			return null;
		}

		public static Spawner GetSpawner(string spawnerName)
		{
			return null;
		}

		public static Pool Add(string poolName, Pool.PoolType poolType, bool enablePoolProtection, bool enablePoolEvents, bool dontDestroyOnLoad, PoolItem[] poolItems, GameObject usingGameObject = null)
		{
			return null;
		}

		public static Pool AddPool(string poolName, Pool.PoolType poolType, bool enablePoolProtection, bool enablePoolEvents, bool dontDestroyOnLoad, PoolItem[] poolItems, GameObject usingGameObject = null)
		{
			return null;
		}

		public static Pool Create(string poolName, Pool.PoolType poolType, bool enablePoolProtection, bool enablePoolEvents, bool dontDestroyOnLoad, PoolItem[] poolItems, GameObject usingGameObject = null)
		{
			return null;
		}

		public static Pool CreatePool(string poolName, Pool.PoolType poolType, bool enablePoolProtection, bool enablePoolEvents, bool dontDestroyOnLoad, PoolItem[] poolItems, GameObject usingGameObject = null)
		{
			return null;
		}

		public static void DespawnAll()
		{
		}

		public static void DespawnAllLocal()
		{
		}

		public static void DespawnAllLocalPools()
		{
		}

		public static void DespawnAllGlobal()
		{
		}

		public static void DespawnAllGlobalPools()
		{
		}

		public static bool Remove(string poolName)
		{
			return false;
		}

		public static bool RemovePool(string poolName)
		{
			return false;
		}

		public static bool DestroyPool(string poolName)
		{
			return false;
		}

		public static void RemoveAll()
		{
		}

		public static void RemoveAllPools()
		{
		}

		public static void DestroyAll()
		{
		}

		public static void DestroyAllPools()
		{
		}

		public static void RemoveAllLocal()
		{
		}

		public static void RemoveAllLocalPools()
		{
		}

		public static void DestroyAllLocal()
		{
		}

		public static void DestroyAllLocalPools()
		{
		}

		public static void RemoveAllGlobal()
		{
		}

		public static void RemoveAllGlobalPools()
		{
		}

		public static void DestroyAllGlobal()
		{
		}

		public static void DestroyAllGlobalPools()
		{
		}

		internal static GameObject InstantiatePrefab(GameObject prefab)
		{
			return null;
		}

		internal static void DestroyInstance(GameObject instance)
		{
		}
	}
}
