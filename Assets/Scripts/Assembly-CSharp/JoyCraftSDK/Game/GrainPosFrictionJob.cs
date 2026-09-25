using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainPosFrictionJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeArray<float2> posPrev;

		[ReadOnly]
		public NativeArray<float2> posPredicted;

		[ReadOnly]
		public NativeArray<float> radii;

		[ReadOnly]
		public float frictionPosMu;

		[ReadOnly]
		public NativeParallelMultiHashMap<int, int> hash;

		[ReadOnly]
		public float cellSize;

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

		[WriteOnly]
		public NativeArray<float2> frictionDelta;

		public void Execute(int i)
		{
		}

		private void PosFrictionPair(int i, int j, float2 pi, float ri, ref float2 impSum, ref int cnt)
		{
		}
	}
}
