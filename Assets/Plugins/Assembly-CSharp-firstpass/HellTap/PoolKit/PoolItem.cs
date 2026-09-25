using System;
using UnityEngine;

namespace HellTap.PoolKit
{
	[Serializable]
	public class PoolItem
	{
		public enum PoolResizeOptions
		{
			KeepPoolSizeFixed = 0,
			ExpandPoolWithinLimit = 1,
			AlwaysExpandPoolWhenNeeded = 2
		}

		public enum PoolScale
		{
			Ignore = 0,
			PrefabScale = 1,
			PoolScale = 2,
			CustomScale = 3,
			RandomRangeCustomScale = 4,
			RandomRangeProportionalScale = 5
		}

		public enum PoolLayer
		{
			Ignore = 0,
			PrefabLayer = 1,
			PoolLayer = 2,
			CustomLayer = 3
		}

		public enum DespawnMode
		{
			Countdown = 0,
			CountdownRandomRange = 1,
			WaitForAudioToFinish = 2,
			WaitForParticleSystemToFinish = 3
		}

		public enum Notifications
		{
			None = 0,
			PoolKitListeners = 1,
			SendMessage = 2,
			BroadcastMessage = 3
		}

		[Header("Prefab")]
		public GameObject prefabToPool;

		[NonSerialized]
		public int prefabToPoolInstanceID;

		[NonSerialized]
		public Pool pool;

		[Header("Pool Item Options")]
		public PoolResizeOptions poolSizeOptions;

		public int poolSize;

		public int limitPoolSize;

		public bool keepOrganized;

		public bool recycleSpawnedObjects;

		[NonSerialized]
		public int recycleNextIndex;

		[Header("Scale Of Spawned Instances")]
		public bool resetScaleOnEverySpawn;

		public PoolScale spawnedItemScale;

		public Vector3 customSpawnScale;

		public Vector3 customSpawnScaleMin;

		public Vector3 customSpawnScaleMax;

		public float customSpawnScaleProportionalMin;

		public float customSpawnScaleProportionalMax;

		[Header("Layer Of Spawned Instances")]
		public bool resetLayerOnEverySpawn;

		public PoolLayer spawnedItemLayer;

		public int customSpawnLayer;

		[Header("Lazy Instance Preloading")]
		public bool useLazyPreloading;

		public int lazyPreloadingInstancesOnAwake;

		public float lazyPreloadingInitialDelay;

		public int lazyPreloadingInstancesPerPass;

		public float lazyPreloadingDelayBetweenPasses;

		[NonSerialized]
		public bool runPreloadingUpdate;

		[Header("Auto-Despawn")]
		public bool enableAutoDespawn;

		public DespawnMode despawnMode;

		public float despawnAfterHowManySeconds;

		public float despawnRandomRangeMin;

		public float despawnRandomRangeMax;

		[Header("Send Notifications To Instances")]
		public Notifications notifications;

		[Header("Delegates")]
		public bool enableInstantiateDelegates;

		public bool enableDestroyDelegates;

		[NonSerialized]
		[Header("Helpers")]
		public int activeInstances;

		[NonSerialized]
		public int inactiveInstances;

		private bool _puFirstPass;

		private float _puInitialDelay;

		private float _delayBetweenPassCounter;

		private int _lazyPreloadCount;

		public int instanceCount => 0;

		internal void PreloadUpdate()
		{
		}
	}
}
