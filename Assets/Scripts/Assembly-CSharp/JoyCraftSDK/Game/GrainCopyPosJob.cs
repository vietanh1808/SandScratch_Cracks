using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainCopyPosJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[WriteOnly]
		public NativeArray<float2> snapshot;

		public void Execute(int i)
		{
		}
	}
}
