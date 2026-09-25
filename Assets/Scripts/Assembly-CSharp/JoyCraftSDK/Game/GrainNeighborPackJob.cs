using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainNeighborPackJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public NativeArray<float2> velocities;

		[ReadOnly]
		public NativeArray<int> entryIdx;

		[WriteOnly]
		public NativeArray<float3> packed;

		public void Execute(int e)
		{
		}
	}
}
