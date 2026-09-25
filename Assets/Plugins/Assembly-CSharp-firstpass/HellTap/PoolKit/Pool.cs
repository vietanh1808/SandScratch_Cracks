using System;
using System.Collections.Generic;
using UnityEngine;

namespace HellTap.PoolKit
{
	public class Pool : MonoBehaviour
	{
		public enum PoolType
		{
			Automatic = 0,
			FixedArray = 1,
			DynamicList = 2
		}

		public delegate void OnPoolSpawnDelegate(Transform instance, Pool pool);

		public delegate void OnPoolDespawnDelegate(Transform instance, Pool pool);

		public delegate GameObject CreateInstanceDelegate(GameObject prefab);

		public delegate void DestroyInstanceDelegate(GameObject instance);

		private Transform _poolItemRootTransform;

		private int _poolItemRootLayer;

		private int _poolItemRootTransformInstanceID;

		[Header("Pool Options")]
		public string poolName;

		public PoolType poolType;

		private bool _usingFixedSizePool;

		public bool poolWasJustCreatedByAPI;

		private bool _poolReady;

		public bool enablePoolEvents;

		public bool enablePoolProtection;

		public bool dontDestroyOnLoad;

		private bool _isGlobalPool;

		[Header("Pool Items")]
		public PoolItem[] poolItems;

		[Header("Spawned Objects")]
		[SerializeField]
		internal PoolKitInstance[] spawnedObjects;

		[SerializeField]
		internal List<PoolKitInstance> spawnedObjectsList;

		public OnPoolSpawnDelegate onPoolSpawn;

		public OnPoolDespawnDelegate onPoolDespawn;

		[SerializeField]
		private int fixedSizeSpawnCount;

		[NonSerialized]
		private int chltpasbTotalCount;

		[NonSerialized]
		private PoolKitInstance _updatePoolKitInstance;

		[NonSerialized]
		private PoolItem _updatePoolKitInstancePoolItem;

		[NonSerialized]
		private float cachedDeltaTime;

		[NonSerialized]
		private List<int> arrayIndexesToFix;

		[NonSerialized]
		private int recycleNextIndex;

		[NonSerialized]
		private Transform spawnStringLocalScale;

		[NonSerialized]
		private Transform spawnToGO;

		[NonSerialized]
		private int _spawnInstanceID;

		[NonSerialized]
		private Transform spawnPrefabLocalScale;

		private PoolItem fixBrokenPoolItem;

		[NonSerialized]
		private PoolItem soPoolItem;

		[NonSerialized]
		private float _spkiProportionalScale;

		[NonSerialized]
		private Vector3 _spkiTempV3;

		[NonSerialized]
		private int _despawnAllPrefabInstanceID;

		[NonSerialized]
		private PoolKitInstance despawnHelperPoolKitInstance;

		[NonSerialized]
		private int _despawnInstanceID;

		[NonSerialized]
		private GameObject _iapoGO;

		[NonSerialized]
		private Transform _iapoGOT;

		[NonSerialized]
		private PoolKitInstance _iapoSO;

		[NonSerialized]
		private float _iapoProportionalScale;

		[NonSerialized]
		private Vector3 _iapoTempV3;

		private const string renamePrefix = "_PoolKit_";

		private const string renameUnderscore = "_";

		private const string renameSpace = " ";

		private const string renameClone = "(Clone)";

		private const string renameEmtpty = "";

		private const string renameIndexFormat = "0000";

		public CreateInstanceDelegate OnCreateInstance;

		public DestroyInstanceDelegate OnDestroyInstance;

		[NonSerialized]
		private int gaic;

		[NonSerialized]
		private int giic;

		public bool IsFixedSizePool()
		{
			return false;
		}

		public bool IsGlobalPool()
		{
			return false;
		}

		internal void StartFromAPI()
		{
		}

		public bool Add(PoolItem pi)
		{
			return false;
		}

		private void Awake()
		{
		}

		private bool CanUseFixedArray()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private int CalculateHowLongThePreloadedArrayShouldBe()
		{
			return 0;
		}

		public bool GameObjectIsNull(GameObject go)
		{
			return false;
		}

		public bool GameObjectIsExplicitlyNull(GameObject go)
		{
			return false;
		}

		public bool TransformIsExplicitlyNull(Transform t)
		{
			return false;
		}

		public void Update()
		{
		}

		private void PoolUpdate(bool applyDeltaTime)
		{
		}

		public int GetRecycleInfo(string goName)
		{
			return 0;
		}

		public int GetRecycleInfo(int instanceID)
		{
			return 0;
		}

		public GameObject SpawnGO(string goName, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(string goName)
		{
			return null;
		}

		public GameObject SpawnGO(string goName, Vector3 position, Vector3 eulerRotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(string goName, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(string goName, Vector3 position, Vector3 eulerRotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(string goName)
		{
			return null;
		}

		public Transform Spawn(string goName, Vector3 position, Vector3 eulerRotation, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(string goName, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(string goName, Vector3 position, Vector3 eulerRotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(string goName, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(Transform prefab, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(GameObject prefab)
		{
			return null;
		}

		public GameObject SpawnGO(Transform prefab)
		{
			return null;
		}

		public GameObject SpawnGO(GameObject prefab, Vector3 position, Vector3 eulerRotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(Transform prefab, Vector3 position, Vector3 eulerRotation, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(GameObject prefab, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(Transform prefab, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(GameObject prefab, Vector3 position, Vector3 eulerRotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public GameObject SpawnGO(Transform prefab, Vector3 position, Vector3 eulerRotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab)
		{
			return null;
		}

		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Vector3 position, Vector3 eulerRotation, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(Transform prefab, Vector3 position, Vector3 eulerRotation, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(Transform prefab, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Vector3 position, Vector3 eulerRotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(Transform prefab, Vector3 position, Vector3 eulerRotation, Vector3 localScale, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(Transform prefab, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return null;
		}

		private void FixBrokenPool(int indexToFix)
		{
		}

		private void SetupPoolKitInstance(PoolKitInstance spawnedObject, Vector3 position, Quaternion rotation, Transform parent = null)
		{
		}

		public void DespawnAll()
		{
		}

		public void DespawnAll(Transform prefab)
		{
		}

		public void DespawnAll(GameObject prefab)
		{
		}

		public void DespawnAll(string prefabName)
		{
		}

		private bool DespawnInstance(int despawnIndex)
		{
			return false;
		}

		public bool Despawn(Transform theInstance)
		{
			return false;
		}

		public bool Despawn(GameObject theInstance)
		{
			return false;
		}

		internal Transform InstantiatePooledObject(PoolItem poolItem, int useArrayIndex = -1)
		{
			return null;
		}

		internal Transform InstantiatePooledObject(PoolItem poolItem, bool setupPoolKitInstance, Vector3 position, Quaternion rotation, Transform parent = null, int useArrayIndex = -1)
		{
			return null;
		}

		private void RenameInstance(GameObject instance, int useArrayIndex = -1)
		{
		}

		private int GetTotalInstanceCount(int useArrayIndex = -1)
		{
			return 0;
		}

		private void SetLayerRecursively(GameObject go, Transform theTransform, int newLayer)
		{
		}

		internal GameObject InstantiatePrefab(GameObject prefab)
		{
			return null;
		}

		internal void DestroyInstance(GameObject instance)
		{
		}

		public PoolItem GetPoolItem(GameObject prefab)
		{
			return null;
		}

		public int GetInstanceCount()
		{
			return 0;
		}

		public int GetInstanceCount(GameObject prefab)
		{
			return 0;
		}

		public int GetInstanceCount(Transform prefab)
		{
			return 0;
		}

		public int GetInstanceCount(string prefabName)
		{
			return 0;
		}

		public int GetActiveInstanceCount()
		{
			return 0;
		}

		public int GetActiveInstanceCount(GameObject prefab)
		{
			return 0;
		}

		public int GetActiveInstanceCount(Transform prefab)
		{
			return 0;
		}

		public int GetActiveInstanceCount(string prefabName)
		{
			return 0;
		}

		public int GetInactiveInstanceCount()
		{
			return 0;
		}

		public int GetInactiveInstanceCount(GameObject prefab)
		{
			return 0;
		}

		public int GetInactiveInstanceCount(Transform prefab)
		{
			return 0;
		}

		public int GetInactiveInstanceCount(string prefabName)
		{
			return 0;
		}

		public PoolKitInstance[] GetPoolKitInstances()
		{
			return null;
		}

		public Transform[] GetInstances()
		{
			return null;
		}

		public Transform[] GetInstances(GameObject prefab)
		{
			return null;
		}

		public Transform[] GetInstances(Transform prefab)
		{
			return null;
		}

		public Transform[] GetInstances(string prefabName)
		{
			return null;
		}

		public Transform[] GetActiveInstances()
		{
			return null;
		}

		public Transform[] GetActiveInstances(GameObject prefab)
		{
			return null;
		}

		public Transform[] GetActiveInstances(Transform prefab)
		{
			return null;
		}

		public Transform[] GetActiveInstances(string prefabName)
		{
			return null;
		}

		public Transform[] GetInactiveInstances()
		{
			return null;
		}

		public Transform[] GetInactiveInstances(GameObject prefab)
		{
			return null;
		}

		public Transform[] GetInactiveInstances(Transform prefab)
		{
			return null;
		}

		public Transform[] GetInactiveInstances(string prefabName)
		{
			return null;
		}

		public bool HasActiveInstances()
		{
			return false;
		}

		public bool HasActiveInstances(GameObject prefab)
		{
			return false;
		}

		public bool HasActiveInstances(Transform prefab)
		{
			return false;
		}

		public bool HasActiveInstances(string prefabName)
		{
			return false;
		}

		public bool HasInactiveInstances()
		{
			return false;
		}

		public bool HasInactiveInstances(GameObject prefab)
		{
			return false;
		}

		public bool HasInactiveInstances(Transform prefab)
		{
			return false;
		}

		public bool HasInactiveInstances(string prefabName)
		{
			return false;
		}
	}
}
