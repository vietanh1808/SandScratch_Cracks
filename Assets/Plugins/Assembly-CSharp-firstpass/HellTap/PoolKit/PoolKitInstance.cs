using System;
using UnityEngine;

namespace HellTap.PoolKit
{
	[Serializable]
	public class PoolKitInstance
	{
		public GameObject instance;

		public string instanceName;

		public Transform instanceTransform;

		public int instanceID;

		public bool isSpawned;

		public bool isRectTransform;

		public float currentDespawnTimer;

		public float aliveTime;

		public GameObject prefab;

		public string prefabOriginalName;

		public int prefabInstanceID;

		[NonSerialized]
		public PoolItem poolItem;

		[NonSerialized]
		public Pool pool;

		public Despawner despawner;

		public AudioSource aSource;

		public ParticleSystem pSystem;

		public PoolItem.Notifications notifications;

		public IPoolKitListener[] listeners;

		public bool hasListeners;

		private const string onSpawn = "OnSpawn";

		private const string onDespawn = "OnDespawn";

		public PoolKitInstance(GameObject theInstance, GameObject thePrefab, PoolItem thePoolItem, Pool ThePool)
		{
		}

		public PoolKitInstance()
		{
		}

		public static PoolKitInstance Clone(PoolKitInstance pki)
		{
			return null;
		}

		public void BroadCastSpawn()
		{
		}

		public void BroadCastDespawn()
		{
		}
	}
}
