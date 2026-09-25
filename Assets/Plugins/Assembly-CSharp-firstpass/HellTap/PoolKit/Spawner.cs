using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace HellTap.PoolKit
{
	[DisallowMultipleComponent]
	public class Spawner : MonoBehaviour
	{
		public enum State
		{
			Stopped = 0,
			Playing = 1,
			Paused = 2
		}

		public enum StartMode
		{
			AutomaticallyOnStart = 0,
			AutomaticallyOnStartAfterDelay = 1,
			AutomaticallyOnEnable = 2,
			AutomaticallyOnEnableAfterDelay = 3,
			OnlyWhenCalledByScript = 4,
			Never = 5
		}

		public enum SpawnDuration
		{
			PlayOnce = 0,
			RepeatXCycles = 1,
			SpawnXInstances = 4,
			CountdownTimer = 2,
			LoopForever = 3
		}

		public enum SpawnerFrequencyMode
		{
			FixedInterval = 0,
			RandomRange = 1
		}

		public enum InstancesPerCycleMode
		{
			FixedNumber = 0,
			RandomRange = 1
		}

		public enum Increment
		{
			PerInstance = 0,
			PerCycle = 1
		}

		public enum PrefabSelection
		{
			SequenceAscending = 0,
			SequenceDescending = 1,
			PingPongAscending = 2,
			PingPongDescending = 3,
			Random = 4,
			RandomWithWeights = 5
		}

		public enum RotationMode
		{
			PrefabDefault = 0,
			SpawnerRotation = 1,
			SpawnPointRotation = 2,
			CustomEulerAngles = 3,
			RandomRotation = 4
		}

		public enum ScaleMode
		{
			PoolDefault = 0,
			PrefabDefault = 1,
			SpawnerScale = 2,
			CustomLocalScale = 3,
			RandomRangeScale = 4,
			RandomRangeProportionalScale = 5
		}

		public enum ParentMode
		{
			Ignore = 0,
			ReparentToSpawner = 1,
			ReparentToSpawnPoint = 2,
			ReparentToCustomTransform = 3
		}

		public enum SpawnLocation
		{
			AtThisTransform = 0,
			UsingTransformList = 1,
			UsingLocalPositionList = 2,
			UsingGlobalPositionList = 3
		}

		public enum SpawningLocalTo
		{
			Spawner = 0,
			CustomTransform = 1
		}

		public enum SpawnPointSelection
		{
			SequenceAscending = 0,
			SequenceDescending = 1,
			PingPongAscending = 2,
			PingPongDescending = 3,
			Random = 4,
			RandomWithWeights = 5
		}

		[Serializable]
		public class TransformSpawnPoint
		{
			public Transform spawnPoint;

			[Range(0f, 100f)]
			public float randomWeight;

			public void Setup()
			{
			}

			public Vector3 GetVector3()
			{
				return default;
			}
		}

		[Serializable]
		public class PositionSpawnPoint
		{
			public Vector3 spawnPoint;

			[Range(0f, 100f)]
			public float randomWeight;

			public void Setup()
			{
			}

			public Vector3 GetVector3(Vector3 offset)
			{
				return default;
			}
		}

		public delegate void OnSpawnerSpawnDelegate(Transform instance);

		public delegate void OnSpawnerStartDelegate();

		public delegate void OnSpawnerStopDelegate();

		public delegate void OnSpawnerPauseDelegate();

		public delegate void OnSpawnerResumeDelegate();

		public delegate void OnSpawnerEndDelegate();

		[Serializable]
		public class UnityTransformEvent : UnityEvent<Transform>
		{
		}

		[Serializable]
		public class PrefabToSpawn
		{
			[Header("Prefab To Spawn")]
			public GameObject prefab;

			[Header("Options")]
			[Range(0f, 100f)]
			public float randomWeight;

			[NonSerialized]
			[Header("Helpers")]
			public Pool pool;

			[NonSerialized]
			public bool hasPool;

			[NonSerialized]
			public Vector3 defaultPrefabPosition;

			[NonSerialized]
			public Quaternion defaultPrefabRotation;

			[NonSerialized]
			public Vector3 defaultPrefabLocalScale;

			private Transform _spawnedObject;

			public void Setup()
			{
			}

			public Transform Spawn(bool usePoolScale, Vector3 position, Quaternion rotation, Vector3 localScale, Transform parent)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003COnEnableAfterDelay_003Ed__97 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Spawner _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COnEnableAfterDelay_003Ed__97(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Spawner _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStart_003Ed__94(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Header("Spawner Name")]
		public string spawnerName;

		public State state;

		private Transform _theTransform;

		[Header("Spawner Start")]
		public StartMode spawningBegins;

		public float autoSpawnDelay;

		[Header("Spawner Duration")]
		public SpawnDuration spawnDuration;

		public float durationCountdown;

		private float _durationCountdownCurrent;

		public int durationRepeatXTimes;

		private int _numberOfSpawnCycles;

		public int durationSpawnXInstances;

		private int _numberOfInstancesSpawned;

		[Header("Spawner Frequency")]
		public SpawnerFrequencyMode frequencyMode;

		public float frequencyFixedInterval;

		public float frequencyRandomMin;

		public float frequencyRandomMax;

		public InstancesPerCycleMode instancesPerCycleMode;

		public int instancesPerCycle;

		public int minInstancesPerCycle;

		public int maxInstancesPerCycle;

		private int _currentInstancesPerCycle;

		public Increment incrementPrefab;

		public Increment incrementPosition;

		public Increment incrementRandomOffsets;

		public Increment incrementRotation;

		public Increment incrementScale;

		[Header("Prefabs To Spawn")]
		public PrefabSelection prefabSelection;

		public PrefabToSpawn[] prefabs;

		[Header("Instance Rotation")]
		public RotationMode rotationMode;

		public Vector3 customRotationEulerAngles;

		private Transform _lastSpawnPointUsed;

		[Header("Instance Scale")]
		public ScaleMode scaleMode;

		public Vector3 customLocalScale;

		public Vector3 customLocalScaleMin;

		public Vector3 customLocalScaleMax;

		public float customLocalScaleProportionalMin;

		public float customLocalScaleProportionalMax;

		[Header("Instance Parent")]
		public ParentMode reparentInstances;

		public Transform customParentTransform;

		[Header("Spawn Locations")]
		public SpawnLocation prefabsWillBeSpawned;

		public SpawningLocalTo spawnPositionsAreLocalTo;

		public Transform spawnLocalTo;

		public SpawnPointSelection spawnPointSelection;

		public TransformSpawnPoint[] spawnpointTransforms;

		public PositionSpawnPoint[] spawnpointPositions;

		public bool addSpawnPointRandomizationRange;

		public Vector3 spawnPointRandomizationRangeMin;

		public Vector3 spawnPointRandomizationRangeMax;

		public bool addSpawnPointRandomizationMinMaxDistance;

		public float spawnPointRandomizationMinDistance;

		public float spawnPointRandomizationMaxDistance;

		[Header("Delegates")]
		public bool enableSpawnerEvents;

		public OnSpawnerSpawnDelegate onSpawnerSpawn;

		public OnSpawnerStartDelegate onSpawnerStart;

		public OnSpawnerStopDelegate onSpawnerStop;

		public OnSpawnerPauseDelegate onSpawnerPause;

		public OnSpawnerResumeDelegate onSpawnerResume;

		public OnSpawnerEndDelegate onSpawnerEnd;

		[Header("Unity Events")]
		public bool enableUnityEventSpawn;

		public bool enableUnityEventStart;

		public bool enableUnityEventStop;

		public bool enableUnityEventPause;

		public bool enableUnityEventResume;

		public bool enableUnityEventEnd;

		public UnityTransformEvent OnSpawnerSpawnUnityEvent;

		public UnityEvent OnSpawnerStartUnityEvent;

		public UnityEvent OnSpawnerStopUnityEvent;

		public UnityEvent OnSpawnerPauseUnityEvent;

		public UnityEvent OnSpawnerResumeUnityEvent;

		public UnityEvent OnSpawnerEndUnityEvent;

		[NonSerialized]
		private bool runSpawner;

		[NonSerialized]
		private bool runSpawnerRequiresSetup;

		[NonSerialized]
		private float runSpawnerTimerUntilNextSpawn;

		private State _previousState;

		[NonSerialized]
		private float _v3Magnitude;

		[NonSerialized]
		private Vector3 _v3Normalized;

		[NonSerialized]
		private PrefabToSpawn _spawnPTS;

		[NonSerialized]
		private Vector3 _spawnPosition;

		[NonSerialized]
		private Vector3 _spawnRandomOffset;

		[NonSerialized]
		private Quaternion _spawnRotation;

		[NonSerialized]
		private Vector3 _spawnScale;

		[NonSerialized]
		private Transform _spawnedInstance;

		[NonSerialized]
		private bool _foundPrefabToUse;

		[NonSerialized]
		private PrefabToSpawn _prefabUsedWhenLastCycleBegan;

		[NonSerialized]
		private Vector3 _positionUsedWhenLastCycleBegan;

		[NonSerialized]
		private Vector3 _randomOffsetUsedWhenLastCycleBegan;

		[NonSerialized]
		private Quaternion _rotationUsedWhenLastCycleBegan;

		[NonSerialized]
		private Vector3 _scaleUsedWhenLastCycleBegan;

		[NonSerialized]
		public int _gpIndex;

		[NonSerialized]
		public bool _gpIndexPingPong;

		[NonSerialized]
		private float[] _gpwwProbabilityList;

		[NonSerialized]
		private float _gpwwTotal;

		[NonSerialized]
		private float _gpwwRandomPoint;

		[NonSerialized]
		private float _gssProportionalScale;

		[NonSerialized]
		public int _gstIndex;

		[NonSerialized]
		public bool _gstIndexPingPong;

		[NonSerialized]
		private float[] _gtwwProbabilityList;

		[NonSerialized]
		private float _gtwwTotal;

		[NonSerialized]
		private float _gtwwRandomPoint;

		[NonSerialized]
		public int _gptIndex;

		[NonSerialized]
		public bool _gptIndexPingPong;

		[NonSerialized]
		public Vector3 _gptpositionOffset;

		[NonSerialized]
		private float[] _gposwwProbabilityList;

		[NonSerialized]
		private float _gposwwTotal;

		[NonSerialized]
		private float _gposwwRandomPoint;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__94))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003COnEnableAfterDelay_003Ed__97))]
		private IEnumerator OnEnableAfterDelay()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void HandleEvents()
		{
		}

		private void CheckIfSpawnerIsFinished()
		{
		}

		private bool EnoughInstancesWereCreatedToStopSpawner()
		{
			return false;
		}

		private float GetSpawnDelay()
		{
			return 0f;
		}

		public Vector3 ClampMagnitude(Vector3 v3, float min, float max)
		{
			return default;
		}

		public void Spawn(GameObject useThisPrefab = null, bool cycleJustStarted = true)
		{
		}

		private PrefabToSpawn GetPrefab()
		{
			return null;
		}

		private PrefabToSpawn GetPrefabSequenceAscending()
		{
			return null;
		}

		private PrefabToSpawn GetPrefabSequenceDescending()
		{
			return null;
		}

		private PrefabToSpawn GetPrefabPingPongAscending()
		{
			return null;
		}

		private PrefabToSpawn GetPrefabPingPongDescending()
		{
			return null;
		}

		private PrefabToSpawn GetPrefabRandom()
		{
			return null;
		}

		private PrefabToSpawn GetPrefabRandomWithWeights()
		{
			return null;
		}

		private Quaternion GetSpawnRotation(PrefabToSpawn pts)
		{
			return default;
		}

		private Vector3 GetSpawnScale(PrefabToSpawn pts)
		{
			return default;
		}

		private Transform GetSpawnParent(Transform spawnPoint = null)
		{
			return null;
		}

		private Vector3 GetSpawnPosition()
		{
			return default;
		}

		private Vector3 GetSpawnPositionFromTransformList()
		{
			return default;
		}

		private Vector3 SetupAndReturnTransformSpawnPoint(TransformSpawnPoint tsp)
		{
			return default;
		}

		private TransformSpawnPoint GetTransformSequenceAscending()
		{
			return null;
		}

		private TransformSpawnPoint GetTransformSequenceDescending()
		{
			return null;
		}

		private TransformSpawnPoint GetTransformPingPongAscending()
		{
			return null;
		}

		private TransformSpawnPoint GetTransformPingPongDescending()
		{
			return null;
		}

		private TransformSpawnPoint GetTransformRandom()
		{
			return null;
		}

		private TransformSpawnPoint GetTransformRandomWithWeights()
		{
			return null;
		}

		private Vector3 GetSpawnPositionFromPositionList(bool globalPositions)
		{
			return default;
		}

		private PositionSpawnPoint GetPositionSequenceAscending()
		{
			return null;
		}

		private PositionSpawnPoint GetPositionSequenceDescending()
		{
			return null;
		}

		private PositionSpawnPoint GetPositionPingPongAscending()
		{
			return null;
		}

		private PositionSpawnPoint GetPositionPingPongDescending()
		{
			return null;
		}

		private PositionSpawnPoint GetPositionRandom()
		{
			return null;
		}

		private PositionSpawnPoint GetPositionRandomWithWeights()
		{
			return null;
		}

		public void Stop()
		{
		}

		public void Play()
		{
		}

		public void RestartAndPlay()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public bool CanSpawn()
		{
			return false;
		}

		public void AddPrefabToSpawner(GameObject prefab, float randomWeight = 100f)
		{
		}

		public void RemovePrefabFromSpawner(GameObject prefab)
		{
		}

		public void ReplacePrefabInSpawner(GameObject oldPrefab, GameObject newPrefab)
		{
		}

		public void SetRandomWeightOfPrefab(GameObject prefab, float newWeight)
		{
		}

		public void SetRandomWeightOfPrefab(int arrayIndex, float newWeight)
		{
		}

		public void SetRandomWeightOfVector3Position(int arrayIndex, float newWeight)
		{
		}

		public void SetRandomWeightOfTransformPosition(int arrayIndex, float newWeight)
		{
		}

		public void SetSpawnPointPosition(int arrayIndex, Vector3 newPosition)
		{
		}
	}
}
