using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainNeighborParityJob : IJob
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeParallelMultiHashMap<int, int> hash;

		[ReadOnly]
		public NativeArray<int> cellStart;

		[ReadOnly]
		public NativeArray<int> entryIdx;

		[ReadOnly]
		public NativeArray<GrainCellGrid> gridInfo;

		[ReadOnly]
		public float cellSize;

		[ReadOnly]
		public int count;

		[ReadOnly]
		public int sampleCount;

		[ReadOnly]
		public int hasHash;

		[WriteOnly]
		public NativeArray<int> result;

		public void Execute()
		{
		}
	}
}
