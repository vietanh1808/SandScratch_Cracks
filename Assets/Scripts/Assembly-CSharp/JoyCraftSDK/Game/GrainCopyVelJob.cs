using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainCopyVelJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> velocities;

		[WriteOnly]
		public NativeArray<float2> snapshot;

		public void Execute(int i)
		{
		}
	}
}
