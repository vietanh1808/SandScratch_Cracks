using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainNeighborPackPosJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeArray<int> entryIdx;

		[WriteOnly]
		public NativeArray<float2> packedPos;

		public void Execute(int e)
		{
		}
	}
}
