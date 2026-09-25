using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainNeighborPackVaJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> velocities;

		[ReadOnly]
		public NativeArray<int> entryIdx;

		[WriteOnly]
		public NativeArray<float> packedVa;

		public void Execute(int e)
		{
		}
	}
}
