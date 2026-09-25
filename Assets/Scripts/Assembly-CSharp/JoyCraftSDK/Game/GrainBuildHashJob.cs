using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainBuildHashJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<float2> positions;

		[ReadOnly]
		public float cellSize;

		public NativeParallelMultiHashMap<int, int>.ParallelWriter hash;

		public void Execute(int i)
		{
		}
	}
}
