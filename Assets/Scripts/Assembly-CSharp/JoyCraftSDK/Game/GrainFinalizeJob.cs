using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainFinalizeJob : IJobParallelFor
	{
		public NativeArray<float2> positions;

		public NativeArray<float2> velocities;

		[ReadOnly]
		public NativeArray<float2> posPredicted;

		[ReadOnly]
		public float dt;

		[ReadOnly]
		public float damping;

		[ReadOnly]
		public float absorbCapMul;

		[ReadOnly]
		public float frictionVelocity;

		[ReadOnly]
		public float frictionSurfaceDrag;

		[ReadOnly]
		public NativeArray<float2> velSnap;

		[ReadOnly]
		public float frictionPos;

		[ReadOnly]
		public NativeArray<float2> frictionDelta;

		[ReadOnly]
		public float settleDamping;

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
		public float2 gravity;

		[ReadOnly]
		public float occSlip;

		[ReadOnly]
		public NativeArray<byte> ghost;

		[ReadOnly]
		public NativeParallelMultiHashMap<int, int> hash;

		[ReadOnly]
		public float cellSize;

		[ReadOnly]
		public NativeArray<float> radii;

		[ReadOnly]
		public NativeArray<int> gridCellStart;

		[ReadOnly]
		public NativeArray<int> gridEntryIdx;

		[ReadOnly]
		public NativeArray<GrainCellGrid> gridInfo;

		[ReadOnly]
		public int useGrid;

		[ReadOnly]
		public float uniformRadius;

		public void Execute(int i)
		{
		}

		private void ApplyPairFriction(int i, ref float2 v)
		{
		}

		private void FrictionPair(int j, float2 pi, float ri, float2 vi, ref float2 impSum, ref int cnt)
		{
		}
	}
}
