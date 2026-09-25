using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainBuildOccNormalsJob : IJobParallelFor
	{
		[ReadOnly]
		public GrainOccupancyField occ;

		[ReadOnly]
		public NativeArray<byte> occSnapshot;

		[WriteOnly]
		public NativeArray<float2> occNormals;

		public void Execute(int index)
		{
		}
	}
}
