using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	[BurstCompile]
	public struct GrainEscapeGuardJob : IJobParallelFor
	{
		public NativeArray<float2> positions;

		public NativeArray<float2> velocities;

		[ReadOnly]
		public GrainSdfField sdf;

		public void Execute(int i)
		{
		}

		private static bool IsEscaped(float2 lp, in GrainSdfField sdf, out byte band)
		{
			band = default;
			return false;
		}

		private static float CorridorHalf(float ly, float y0, float y1, float h0, float h1)
		{
			return 0f;
		}
	}
}
