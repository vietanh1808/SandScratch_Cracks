using System;
using UnityEngine;
using UnityEngine.Events;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class Despawner : MonoBehaviour
	{
		public enum DespawnMode
		{
			AfterCountdown = 0,
			AfterCountdownWithRandomRange = 1,
			AfterParticleSystemFinishes = 2,
			AfterAudioSourceFinishes = 3,
			AfterPhysicsOverlapEvent = 4,
			AfterPhysicsCollisionEvent = 5,
			AfterPhysicsTriggerEvent = 6,
			AfterPhysicsCollision2DEvent = 7,
			AfterPhysicsTrigger2DEvent = 8,
			AfterPhysicsRaycastEvent = 10,
			AfterPhysicsRaycast2DEvent = 11,
			AfterCalledByScript = 9
		}

		public enum ReferenceLocation
		{
			OnThisGameObject = 0,
			OnAnotherGameObject = 1
		}

		public enum OverlapType
		{
			Sphere3D = 0,
			Circle2D = 1,
			Box3D = 2,
			Box2D = 3
		}

		public enum CollisionSource
		{
			ThisGameObject = 0,
			AnotherChildGameObject = 1,
			ManualSetup = 2
		}

		public delegate void OnDespawnerDespawn();

		public delegate void OnDespawnerCollided(GameObject gameObject);

		public delegate void OnDespawnerChainSpawn(Transform instance);

		[Serializable]
		public class UnityTransformEvent : UnityEvent<Transform>
		{
		}

		[Serializable]
		public class UnityGameObjectEvent : UnityEvent<GameObject>
		{
		}

		[Serializable]
		public class ChainableSpawn
		{
			public enum RotationMode
			{
				PrefabDefault = 0,
				ThisTransformRotation = 1,
				CustomEulerAngles = 2,
				RandomRotation = 3
			}

			public enum ScaleMode
			{
				PrefabDefault = 0,
				PoolDefault = 1,
				ThisTransformScale = 2,
				CustomLocalScale = 3,
				RandomRangeScale = 4,
				RandomRangeProportionalScale = 5
			}

			public enum TimesToSpawnMode
			{
				FixedNumber = 0,
				RandomRange = 1
			}

			[Header("References")]
			public GameObject prefab;

			public SpawnOptions spawnOptions;

			internal Pool pool;

			internal Despawner despawner;

			[Header("Physics Event Conditions")]
			public bool usePhysicsEventFilters;

			public LayerMask filterLayers;

			public string[] filterTags;

			public string[] filterNames;

			[Header("Cached Prefab Helpers")]
			internal bool _hasPrefab;

			internal Vector3 _defaultPrefabPosition;

			internal Quaternion _defaultPrefabRotation;

			internal Vector3 _defaultPrefabLocalScale;

			[Header("Spawn Position")]
			public ChainSpawnLocation spawnAt;

			public Transform customSpawnTransform;

			public Vector3 localPositionOffset;

			public bool addRandomizationRange;

			public Vector3 randomizationRangeMin;

			public Vector3 randomizationRangeMax;

			[Header("Spawn Rotation")]
			public RotationMode rotationMode;

			public Vector3 customRotationEulerAngles;

			[Header("Spawn Scale")]
			public ScaleMode scaleMode;

			public Vector3 customLocalScale;

			public Vector3 customLocalScaleMin;

			public Vector3 customLocalScaleMax;

			public float customLocalScaleProportionalMin;

			public float customLocalScaleProportionalMax;

			public CustomScaleOptions customScaleOptions;

			[Header("Repeat")]
			public TimesToSpawnMode timesToSpawnMode;

			public int timesToSpawnThisObject;

			public int minTimesToSpawnThisObject;

			public int maxTimesToSpawnThisObject;

			private Transform _spawnedT;

			private int _currentTimesToSpawnThisObject;

			private bool _clatanTagFound;

			private bool _clatanNameFound;

			[NonSerialized]
			private Vector3 _getSpawnPosHelper;

			[NonSerialized]
			private Vector3 _gssCurrentScale;

			[NonSerialized]
			private float _gssProportionalScale;

			[NonSerialized]
			private float _gssVectorHelper;

			internal void Spawn(bool triggeredByPhysicsEvent, GameObject referenceToLastCollidedPhysicsGameObject)
			{
			}

			internal bool CheckLayersAndTagsAndNames(GameObject go)
			{
				return false;
			}

			private Vector3 GetSpawnPosition()
			{
				return default;
			}

			private Vector3 RandomizePosition(Vector3 pos)
			{
				return default;
			}

			private Quaternion GetSpawnRotation()
			{
				return default;
			}

			private Vector3 GetSpawnScale()
			{
				return default;
			}
		}

		public enum ChainSpawnLocation
		{
			ThisTransform = 0,
			AnotherChildTransform = 1,
			LastCollision = 2
		}

		public enum SpawnOptions
		{
			AlwaysSpawn = 0,
			SpawnOnlyOnPhysicsEvent = 1,
			SpawnExceptOnPhysicsEvent = 2,
			NeverSpawn = 3
		}

		public enum CustomScaleOptions
		{
			None = 0,
			MultiplyWithLocalScale = 1,
			MultiplyWithSmallestLocalScaleVector = 2,
			MultiplyWithLargestLocalScaleVector = 3,
			MultiplyWithAverageLocalScaleVector = 4,
			MultiplyWithLocalScaleX = 5,
			MultiplyWithLocalScaleY = 6,
			MultiplyWithLocalScaleZ = 7
		}

		[Header("References")]
		public Pool pool;

		private Transform _thisTransform;

		public float aliveTime;

		private Rigidbody rb;

		private Rigidbody2D rb2D;

		[Header("When To Despawn")]
		public DespawnMode despawnMode;

		[Header("Despawn After Countdown")]
		public float despawnCountdown;

		public float despawnCountdownRandomMin;

		public float despawnCountdownRandomMax;

		private float _currentDespawnCountdown;

		[Header("Despawn After Particle System")]
		public ReferenceLocation particleSystemToUse;

		public ParticleSystem useThisParticleSystem;

		public bool playParticleSystemOnSpawn;

		[Header("Despawn After Audio Source")]
		public ReferenceLocation audioSourceToUse;

		public AudioSource useThisAudioSource;

		public bool playAudioSourceOnSpawn;

		public OverlapType overlapType;

		public Vector3 overlapOffset;

		public float overlapRadius;

		public Vector3 overlapScale;

		public bool overlapAlsoDespawnAfterCountdown;

		public float overlapCountdown;

		[Header("Despawn After Collider Event")]
		public bool colliderAlsoDespawnAfterCountdown;

		public float colliderCountdown;

		public bool useCollisionEnter;

		public bool useCollisionStay;

		public bool useCollisionExit;

		[Header("Despawn After Trigger Event")]
		public bool triggerAlsoDespawnAfterCountdown;

		public float triggerCountdown;

		public bool useTriggerEnter;

		public bool useTriggerStay;

		public bool useTriggerExit;

		[Header("Despawn After Collider 2D Event")]
		public bool collider2DAlsoDespawnAfterCountdown;

		public float collider2DCountdown;

		public bool useCollisionEnter2D;

		public bool useCollisionStay2D;

		public bool useCollisionExit2D;

		[Header("Despawn After Trigger 2D Event")]
		public bool trigger2DAlsoDespawnAfterCountdown;

		public float trigger2DCountdown;

		public bool useTriggerEnter2D;

		public bool useTriggerStay2D;

		public bool useTriggerExit2D;

		[Header("Despawn After Raycast Event")]
		public bool raycast3DAlsoDespawnAfterCountdown;

		public float raycast3DCountdown;

		public int raycast3DmaxHits;

		public float raycast3DDistance;

		public Vector3 raycast3DDirection;

		[Header("Despawn After Raycast 2D Event")]
		public bool raycast2DAlsoDespawnAfterCountdown;

		public float raycast2DCountdown;

		public int raycast2DmaxHits;

		public float raycast2DDistance;

		public Vector2 raycast2DDirection;

		public float raycast2DMinZDepth;

		public float raycast2DMaxZDepth;

		[Header("Source Of Collision Events")]
		public CollisionSource sourceOfCollisions;

		public GameObject collisionSourceGameObject;

		public bool resetRigidbodyVelocitiesOnSpawn;

		public LayerMask filterLayers;

		public string[] filterTags;

		public QueryTriggerInteraction queryTriggerInteraction;

		[Header("Chain Spawning")]
		public Vector3 lastCollisionPoint;

		public GameObject lastCollidedPhysicsGameObject;

		public ChainableSpawn[] chainableSpawns;

		[Header("Delegates")]
		public bool enableDespawnerEvents;

		public OnDespawnerDespawn onDespawnerDespawn;

		public OnDespawnerCollided onDespawnerCollided;

		public OnDespawnerChainSpawn onDespawnerChainSpawn;

		[Header("Unity Events")]
		public bool useOnDespawnUnityEvent;

		public UnityEvent OnDespawnUnityEvent;

		public bool useOnChainSpawnUnityEvent;

		public UnityTransformEvent OnChainSpawnUnityEvent;

		public bool useOnPhysicsCollidedUnityEvent;

		public UnityGameObjectEvent OnPhysicsCollidedUnityEvent;

		private bool ranAwake;

		private bool _clatTagFound;

		private bool _userTriggeredCountdown;

		private float _userDespawnCountdown;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void UpdateCountdown()
		{
		}

		private void UpdateParticleSystem()
		{
		}

		private void UpdateAudioSource()
		{
		}

		private void UpdateOverlapTimer()
		{
		}

		private void UpdateColliderTimer()
		{
		}

		private void UpdateTriggerTimer()
		{
		}

		private void UpdateCollider2DTimer()
		{
		}

		private void UpdateTrigger2DTimer()
		{
		}

		private void UpdateRaycastTimer()
		{
		}

		internal bool CheckLayersAndTags(GameObject go)
		{
			return false;
		}

		public void Despawn(float despawnCountdown)
		{
		}

		public void Despawn(float minimumDespawnCountdown, float maximimDespawnCountdown)
		{
		}

		public void Despawn(bool triggeredByPhysicsEvent = false)
		{
		}
	}
}
