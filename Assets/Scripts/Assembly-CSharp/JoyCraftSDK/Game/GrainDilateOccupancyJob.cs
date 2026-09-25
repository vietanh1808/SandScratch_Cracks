using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainDilateOccupancyJob : IJobParallelFor
	{
		public int width;

		public int height;

		public int radius;

		[ReadOnly]
		public NativeArray<byte> src;

		[WriteOnly]
		public NativeArray<byte> dst;

		public void Execute(int index)
		{
		}
	}
}
