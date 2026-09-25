using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using JoyCraftSDK.Utilities;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	public class GrainFlowBackend : JMonoBehaviour, ISandFlowBackend, IConvertPauseSource, ISandHarvestBackend
	{
		public static class StageDiag
		{
			public static bool Enabled;

			public static int EveryFrames;

			public static int BatchCcd;

			public static int AbSubdivA;

			public static int AbSubdivB;

			public static bool LocalityProbe;

			public static bool AbPacked;

			public static bool PackParity;

			public static bool OverlapProbe;

			public static int AbItersA;

			public static int AbItersB;

			static StageDiag()
			{
			}
		}

		public static class StuckDiag
		{
			public static bool Enabled;

			public static int EveryFrames;

			public static float MoveEpsWorld;

			public static float NetEpsWorld;

			public static int MinSamples;

			public static int SampleCap;

			public static float WallPushEps;

			public static bool EdgeOnly;

			public static bool SkipTwins;

			public static float TwinEpsWorld;

			public static bool TracePos;

			public static int TraceMaxCount;

			public static int TraceIndex;

			public static bool TraceIters;
		}

		public static class NeighborDiag
		{
			public static bool Enabled;

			public static bool LogOnlyMismatch;

			public static int SampleCount;
		}

		public static class BeltDiag
		{
			public static bool Enabled;

			public static float ProbeX;

			public static float ProbeY;

			public static float HalfX;

			public static float HalfY;

			public static string CsvPath;

			public static int MaxRows;

			public static int EveryNFrames;
		}

		[BurstCompile]
		private struct GrainRegionCountJob : IJob
		{
			[ReadOnly]
			public NativeArray<float2> positions;

			public int count;

			public float4x4 worldToLocal;

			public float beltHalfX;

			public float beltTopY;

			[WriteOnly]
			public NativeArray<int> result;

			public void Execute()
			{
			}
		}

		private const string Group_Refs = "Refs";

		private const string Group_Geometry = "Geometry (SDF containment — dùng chung SO với ObiFlowBackend, s2)";

		private const string Group_Wire = "Wire gameplay (s4)";

		[Tooltip("Model tranh 3-state + world mapping (WP-A). Gán -> Build dựng carve + ConversionFront pop pixel. BẮT BUỘC để có emit.")]
		[SerializeField]
		private PictureColliderBuilder pictureCarve;

		[Tooltip("Wavefront convert tranh->hạt. Gán -> Build gọi Begin(this) để đợt convert phọt hạt qua AcceptSand.")]
		[SerializeField]
		private ConversionFront conversionFront;

		[Tooltip("Nguồn màu cát (khớp LevelSpawner/ObiFlowBackend). Bỏ trống -> fallback bảng hex GameObjectColorPalette.")]
		[SerializeField]
		private ColorDefinitionSO colorDefinition;

		[Tooltip("Material render instanced (shader SandFlow/GrainInstanced). Bỏ trống -> tạo runtime Shader.Find (OK Editor; device cần shader trong Always Included Shaders hoặc gán asset ở đây).")]
		[SerializeField]
		private Material instancedGrainMaterial;

		[Tooltip("Material đã tune (GrainFlat.mat) — copy _GrainScale/_BorderWidth/_BorderAlpha sang material runtime để giữ cỡ/vành hạt.")]
		[SerializeField]
		private Material grainStyleSource;

		[Tooltip("Bundle 3 config hệ cát (ConveyorShape + Tuning + Layout) — 1 ref DUY NHẤT thay 3 field rời, dùng CHUNG asset với ConveyorController/ConversionFront/PictureColliderBuilder/LevelSpawner nên tường SDF Grain KHÔNG thể lệch cỡ stadium/hình học nữa. Bỏ trống (hoặc thiếu field bên trong) -> KHÔNG containment (hạt rơi xuyên như s1).")]
		[SerializeField]
		private SandFlowConfig sandFlowConfig;

		[Tooltip("Anchor level dựng SDF (khớp flowRoot của ObiFlowBackend để tường trùng chỗ hạt rơi). Bỏ trống -> transform này.")]
		[SerializeField]
		private Transform flowRoot;

		[Tooltip("Vẽ gizmo viền tường SDF (2 vành stadium + funnel/chute/khung) trong Scene view khi Play — Grain KHÔNG có collider GO nên đây là cách DUY NHẤT soi/căn vị trí tường (thay DebugDrawStaticColliders của Obi).")]
		[SerializeField]
		private bool drawSdfGizmos;

		[Tooltip("Màu gizmo viền tường SDF.")]
		[SerializeField]
		private Color sdfGizmoColor;

		[Tooltip("Jar sink: dò hạt đúng màu ở miệng jar -> huỷ + raise arrival (s4). DÙNG CHUNG instance với ObiFlowBackend trong scene. Bỏ trống -> KHÔNG harvest (chỉ chảy, manual test).")]
		[SerializeField]
		private ObiJarSink jarSink;

		[Tooltip("Gate belt-full (theo SỐ HẠT grain) + lose-timer — bind FillRatio của backend này (s4). Bỏ trống -> KHÔNG gate.")]
		[FormerlySerializedAs("maxPixelGate")]
		[SerializeField]
		private MaxGrainGate maxGrainGate;

		[Tooltip("Jar controller: đích cộng count qua OnPixelArrivedAtJar (seam) — BindBackend(this) ở Build (s4). DÙNG CHUNG instance với ObiFlowBackend. Bỏ trống -> KHÔNG harvest/count.")]
		[SerializeField]
		private ColorJarController colorJarController;

		[Tooltip("Sink của booster THỔI CÁT (BoosterBlower): ghim cát chưa vào belt + hút TOÀN BỘ hạt belt -> fill box. Build gọi Begin(this) (sink KHÔNG cần wire ngược lại backend). Bỏ trống -> booster chỉ chạy visual.")]
		[FormerlySerializedAs("magnetSink")]
		[SerializeField]
		private SandBlowerSink sandBlowerSink;

		[CompilerGenerated]
		private Action<int, int> m_OnPixelArrivedAtJar;

		[CompilerGenerated]
		private Action<bool> m_OnConvertPauseChanged;

		private readonly GrainParticlePool _pool;

		private GrainInstancedRenderer _renderer;

		private Vector4[] _colorLut;

		private bool _built;

		private bool _convertPaused;

		private int _regionGrainCount;

		private int _maxGrains;

		private bool _directJarPending;

		private int _solverStepFrame;

		private int _solverStepsThisFrame;

		private bool _magnetFreeze;

		private float2[] _freezePos;

		private bool[] _freezeMask;

		private int _freezeCount;

		private GrainSdfField _sdf;

		private NativeArray<GrainWallSegment> _segments;

		private int _hasSdf;

		private GrainWallGrid _wallGrid;

		private NativeArray<int> _wallCellStart;

		private NativeArray<int> _wallCellItems;

		private NativeArray<ulong> _wallCellMask;

		private float _doorOpenness;

		private float _doorTarget;

		private float _doorDesired;

		private int _hasDoor;

		private bool _beltFull;

		private bool _clearedSpeedUpFired;

		private GrainWallSegment _door;

		private NativeArray<float2> _delta;

		private NativeArray<float2> _posPredicted;

		private NativeArray<float2> _velSnap;

		private NativeArray<float2> _posPrev;

		private NativeArray<float2> _frictionDelta;

		private NativeParallelMultiHashMap<int, int> _hashMap;

		private NativeArray<float2> _stuckPrevPos;

		private NativeArray<float2> _stuckAnchorPos;

		private NativeArray<byte> _stuckHits;

		private bool _stuckArmed;

		private int _stuckPrevCount;

		private readonly List<int> _stuckCand;

		private readonly List<bool> _stuckCandMoved;

		private readonly List<bool> _stuckCandTwin;

		private float2[][] _tracePos;

		private float2[][] _traceVel;

		private string[] _traceName;

		private int _traceStageCount;

		private int _traceCount;

		private float2[][] _iterPos;

		private float2[][] _iterDelta;

		private int _iterStageCount;

		private NativeArray<int> _nbCellStart;

		private NativeArray<int> _nbCursor;

		private NativeArray<int> _nbCellIndex;

		private NativeArray<int> _nbEntryIdx;

		private NativeArray<GrainCellGrid> _nbGridInfo;

		private NativeArray<int> _nbParityResult;

		private NativeArray<float3> _nbPacked;

		private NativeArray<float2> _nbPackedPos;

		private NativeArray<float> _nbPackedVa;

		private NativeArray<int4> _stPenHist;

		private NativeArray<float2> _stPenStat;

		private const int DepthBuckets = 8;

		private readonly int[] _dpGrains;

		private readonly long[] _dpContacts;

		private readonly double[] _dpPenSum;

		private readonly long[] _dpB3;

		private readonly Stopwatch _stSw;

		private double _stMsPre;

		private double _stMsJ2;

		private double _stMsCcd;

		private double _stMsAccum;

		private double _stMsApply;

		private double _stMsFriction;

		private double _stMsJ4;

		private double _stMsEscape;

		private double _stMsRepack;

		private double _stMsProbeSeq;

		private double _stMsProbeRand;

		private NativeArray<float2> _deltaScrap;

		private NativeArray<byte> _stCcdFlag;

		private NativeArray<int> _stCandCount;

		private NativeArray<int> _stContactCount;

		private NativeArray<float4> _stClampAcc;

		private NativeArray<byte> _occSnapshot;

		private NativeArray<byte> _occSnapshotRaw;

		private NativeArray<float2> _occNormals;

		private GrainOccupancyField _occ;

		private int _hasOcc;

		private NativeArray<int> _regionCountResult;

		private const int FallbackCapacity = 2700;

		private static bool _fpSolverColdDone;

		private static bool _fpSolverUpdColdDone;

		private static readonly string[] StuckReasonName;

		private StringBuilder _diagSb;

		private int _diagRows;

		private bool _diagWasOn;

		private string _diagResolvedPath;

		private const int FlowEnterGrains = 6;

		private const int FlowExitGrains = 0;

		private bool _beltFlowActive;

		private bool _dropFlowActive;

		public static int HarvestPath;

		private ConveyorShapeData ConveyorShape => null;

		private GrainTuningConfig TuningConfig => null;

		private ObiFlowLayoutConfig LayoutConfig => null;

		public PictureColliderBuilder PictureCarve => null;

		public int RegionPixelCount => 0;

		public float FillRatio => 0f;

		public bool ConvertPaused => false;

		public float DoorOpenness => 0f;

		public int LiveGrainCount => 0;

		public Vector2 BeltCenterlineWorldPos => default;

		public Material InstancedGrainMaterial => null;

		public Material CapturedGrainMaterial => null;

		public Vector4[] CapturedGrainColorLut => null;

		public event Action<int, int> OnPixelArrivedAtJar
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool> OnConvertPauseChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private int ResolveCapacity(PixelLevelData pld)
		{
			return 0;
		}

		public void Build(PixelLevelData pixelLevelData, bool grainyLook, List<ColorJarColumnData> colorJarColumns)
		{
		}

		public void AcceptSand(SandEmitRequest request)
		{
		}

		public int GhostifyGrainsOfColor(int colorId, float releaseY)
		{
			return 0;
		}

		public void HaltConvertForSwap()
		{
		}

		public void Clear()
		{
		}

		private void DisposeContact()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnFixedUpdateEvent(ref AEventManager.OnFixedUpdate eventData)
		{
		}

		private void RunSolverStep(float dt)
		{
		}

		private int ResolveNeighborSubdiv()
		{
			return 0;
		}

		private int ResolveContactIterations()
		{
			return 0;
		}

		private int ResolvePackMode()
		{
			return 0;
		}

		private double StageLap(ref JobHandle handle)
		{
			return 0.0;
		}

		private void LogStageDiag(int count, int substeps, int iters, float ccdGate, int useGrid, float uniformRadius)
		{
		}

		private void LogClampDiag(int count)
		{
		}

		private void LogOverlapDiag(int count)
		{
		}

		private void LogDepthDiag(int count, bool penOn)
		{
		}

		private void CaptureTrace(string stage, int count)
		{
		}

		private void CaptureIter(int k, int count)
		{
		}

		private void LogPosTrace()
		{
		}

		private void OnUpdateEvent(ref AEventManager.OnUpdate eventData)
		{
		}

		private void SampleStuckDiag(in GrainIntegrateJob job)
		{
		}

		private void RunNeighborParity(int count, float cellSize)
		{
		}

		private int CountNonUniformRadius(int count, float uniformRadius)
		{
			return 0;
		}

		private void SampleBeltDiag(in GrainIntegrateJob job)
		{
		}

		private void FlushBeltDiag()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void RecomputeRegionCount()
		{
		}

		private void SetBeltFlowActive(bool active)
		{
		}

		private void SetDropFlowActive(bool active)
		{
		}

		private void TickFlowAudioSignals()
		{
		}

		public int CountBeltGrainsNow()
		{
			return 0;
		}

		private bool IsInBeltLocal(float2 world)
		{
			return false;
		}

		private bool IsInBlowerCaptureLocal(float2 world)
		{
			return false;
		}

		public void CollectBeltColorCounts(Dictionary<int, int> counts)
		{
		}

		private void SetConvertPaused(bool paused)
		{
		}

		private void HandleBeltFull(bool full)
		{
		}

		public int HarvestJar(Bounds mouthWorldBounds, int colorId, int maxAcceptPixels, List<ObiFlowEmitters.HarvestedGrain> results = null, bool raiseArrival = true)
		{
			return 0;
		}

		private int HarvestJarLegacy(Bounds mouthWorldBounds, int colorId, int maxAcceptPixels, List<ObiFlowEmitters.HarvestedGrain> results, bool raiseArrival)
		{
			return 0;
		}

		private int HarvestJarHoisted(Bounds mouthWorldBounds, int colorId, int maxAcceptPixels, List<ObiFlowEmitters.HarvestedGrain> results, bool raiseArrival)
		{
			return 0;
		}

		public void SetInstancedGrainMaterial(Material mat)
		{
		}

		public void SetBlowerFreeze(bool active)
		{
		}

		public int BlowerPass(Vector3 laserWorld, float radius, List<ObiFlowEmitters.HarvestedGrain> results)
		{
			return 0;
		}

		public int HarvestDirectToJar(Func<int, int, DirectJarVerdict> verdict, List<ObiFlowEmitters.HarvestedGrain> results)
		{
			return 0;
		}

		public void SetBoosterConvertPause(bool paused)
		{
		}

		private void SnapshotFrozen()
		{
		}

		private void RestoreFrozen()
		{
		}

		public void DebugCountJar(Bounds mouthWorldBounds, int colorId, out int total, out int matching)
		{
			total = default;
			matching = default;
		}

		private void BuildColorLut()
		{
		}

		private Color ResolveColor(int colorId)
		{
			return default;
		}

		private void BuildSdfField()
		{
		}

		private static void BuildSideCorners(int sign, bool frame, bool hasChute, float wallX, float funnelTopY, float wallTop, float chuteInHalf, float chuteTopY, float gapHalf, float rOut, float frameR, float junctionR, List<Vector2> corners, List<float> radii)
		{
		}

		private static List<Vector2> BuildFilletedPolyline(List<Vector2> corners, List<float> radii, int arcSegs)
		{
			return null;
		}

		private static void AppendFilletedCorner(List<Vector2> pts, Vector2 a, Vector2 b, Vector2 c, float r, int segs)
		{
		}

		private static void AppendPolylineSegments(List<GrainWallSegment> segs, List<Vector2> pts)
		{
		}

		private void DisposeSdf()
		{
		}

		private void BuildWallGrid()
		{
		}

		private static void WallGridCellRange(GrainWallSegment seg, Vector2 origin, float cell, int nx, int ny, float pad, out int x0, out int y0, out int x1, out int y1)
		{
			x0 = default;
			y0 = default;
			x1 = default;
			y1 = default;
		}

		private void BuildOccupancyField(PixelLevelData pixelLevelData)
		{
		}

		public void RefreshOccupancyAffine()
		{
		}

		public bool AnyGrainInWorldRect(Rect worldRect)
		{
			return false;
		}

		public int CountGrainInWorldRect(Rect worldRect, int cap)
		{
			return 0;
		}

		private static float4x4 ToFloat4x4(Matrix4x4 m)
		{
			return default;
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawSdfGizmos()
		{
		}

		private void DrawStadiumGizmo(float r, float4x4 l2w)
		{
		}

		private static void GizmoArc(List<float2> pts, float cx, float cy, float r, float fromDeg, float toDeg, int segs)
		{
		}

		private static Vector3 GizmoXf(float4x4 m, float2 p)
		{
			return default;
		}
	}
}
