using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainIntegrateJob : IJobParallelFor
	{
		public NativeArray<float2> positions;

		public NativeArray<float2> velocities;

		[WriteOnly]
		public NativeArray<float2> posPredicted;

		[ReadOnly]
		public float2 gravity;

		[ReadOnly]
		public float dt;

		[ReadOnly]
		public int hasSdf;

		[ReadOnly]
		public GrainSdfField sdf;

		[ReadOnly]
		public NativeArray<GrainWallSegment> segments;

		[ReadOnly]
		public float restitution;

		[ReadOnly]
		public float frictionKeep;

		[ReadOnly]
		public float beltSpeed;

		[ReadOnly]
		public float beltCoupling;

		[ReadOnly]
		public float beltRadialDamping;

		[ReadOnly]
		public float beltTopRelease;

		[ReadOnly]
		public float beltTopReleaseStart;

		[ReadOnly]
		public float beltTopTangentDamp;

		[ReadOnly]
		public float beltSpeedUp;

		[ReadOnly]
		public float beltCouplingUp;

		[ReadOnly]
		public float beltRadialDampingUp;

		[ReadOnly]
		public float beltTopReleaseUp;

		[ReadOnly]
		public float beltTopReleaseStartUp;

		[ReadOnly]
		public float beltTopTangentDampUp;

		[ReadOnly]
		public float funnelSlideSpeed;

		[ReadOnly]
		public float funnelSlideCoupling;

		[ReadOnly]
		public float funnelSlideMinSpeed;

		[ReadOnly]
		public int enforceOneWay;

		[ReadOnly]
		public int substeps;

		[ReadOnly]
		public int hasDoor;

		[ReadOnly]
		public GrainWallSegment door;

		[ReadOnly]
		public int hasOcc;

		[ReadOnly]
		public GrainOccupancyField occ;

		[ReadOnly]
		public NativeArray<byte> occSnapshot;

		[ReadOnly]
		public NativeArray<byte> occSnapshotRaw;

		[ReadOnly]
		public NativeArray<float2> occNormals;

		[ReadOnly]
		public float occSlip;

		public NativeArray<byte> ghost;

		[ReadOnly]
		public NativeArray<float> ghostReleaseY;

		[ReadOnly]
		public int wgiEnabled;

		[ReadOnly]
		public GrainWallGrid wallGrid;

		[ReadOnly]
		public NativeArray<ulong> wallCellMask;

		public void Execute(int i)
		{
		}

		private void ResolveContainment(ref float2 p, ref float2 v, float sdt, float2 pPrev, float2 vStepStart)
		{
		}

		private void ApplyFunnelSlide(ref float2 v, float2 nLocalSum, float sdt, float2 vStepStart)
		{
		}

		private void ReflectVel(ref float2 v, float2 nLocal)
		{
		}
	}
}
