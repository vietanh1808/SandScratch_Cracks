using Unity.Collections;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	public static class GrainSdfWalls
	{
		public const int SweepMaxCells = 32;

		public static float Thr(in GrainSdfField sdf)
		{
			return 0f;
		}

		public static bool ClampInner(ref float2 lp, in GrainSdfField sdf, out float2 n)
		{
			n = default;
			return false;
		}

		public static bool ClampOuter(ref float2 lp, float2 lpPrev, in GrainSdfField sdf, out float2 n)
		{
			n = default;
			return false;
		}

		public static bool ClampSegment(GrainWallSegment seg, ref float2 lp, float2 lpPrev, in GrainSdfField sdf, out float2 n, float thrOverride = -1f)
		{
			n = default;
			return false;
		}

		private static bool CrossesSegment(GrainWallSegment seg, float2 lpPrev, float2 lp, out float2 hit, out float2 n)
		{
			hit = default;
			n = default;
			return false;
		}

		public static void ClampWorld(ref float2 p, float2 pPrev, in GrainSdfField sdf, NativeArray<GrainWallSegment> segments, int hasDoor, in GrainWallSegment door, float compliance)
		{
		}

		public static int CellOf(in GrainWallGrid grid, float2 lp)
		{
			return 0;
		}

		public static bool WallMaskForSweep(in GrainWallGrid grid, NativeArray<ulong> cellMask, float2 lpPrev, float2 c, out ulong mask, out float2 rMin, out float2 rMax)
		{
			mask = default;
			rMin = default;
			rMax = default;
			return false;
		}

		public static bool ClampWorld(ref float2 p, float2 pPrev, in GrainSdfField sdf, NativeArray<GrainWallSegment> segments, int hasDoor, in GrainWallSegment door, float compliance, in GrainWallGrid grid, NativeArray<int> cellStart, NativeArray<int> cellItems)
		{
			return false;
		}
	}
}
