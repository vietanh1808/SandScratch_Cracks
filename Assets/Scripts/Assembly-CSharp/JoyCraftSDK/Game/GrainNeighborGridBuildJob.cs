using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainNeighborGridBuildJob : IJob
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public float cellSize;

		[ReadOnly]
		public int count;

		[ReadOnly]
		public int maxDim;

		[ReadOnly]
		public int subdiv;

		public NativeArray<int> cellIndex;

		public NativeArray<int> cellStart;

		public NativeArray<int> cursor;

		public NativeArray<int> entryIdx;

		[WriteOnly]
		public NativeArray<GrainCellGrid> gridInfo;

		public void Execute()
		{
		}
	}
}
