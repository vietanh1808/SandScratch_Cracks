using Unity.Collections;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	public static class GrainOccupancy
	{
		private const int SlideBounces = 3;

		public const int CreepOff = 0;

		public const int CreepNoGravity = 1;

		public const int CreepApronBlocked = 2;

		public const int CreepApronStep = 3;

		public const int CreepNotResting = 4;

		public const int CreepLedgeShed = 5;

		public const int CreepNoDownhill = 6;

		public const int CreepDownhillStep = 7;

		public const int CreepLedgeShedOutward = 8;

		public const int CreepDownhillStepOutward = 9;

		public static void SweepBlocked(ref float2 p, ref float2 v, float2 pPrev, in GrainOccupancyField occ, NativeArray<byte> snapshot, NativeArray<byte> snapshotRaw, NativeArray<float2> normals, float sdt, float2 gravity, float slip)
		{
		}

		public static void CreepDownhill(ref float2 p, in GrainOccupancyField occ, NativeArray<byte> snapshot, NativeArray<byte> snapshotRaw, float sdt, float2 gravity, out int reason)
		{
			reason = default;
		}

		public static void ProbeStuckCell(float2 p, in GrainOccupancyField occ, NativeArray<byte> snapshot, out int ox, out int oy, out int oxMin, out int oxMax, out int flags)
		{
			ox = default;
			oy = default;
			oxMin = default;
			oxMax = default;
			flags = default;
		}

		private static int LedgeRun(NativeArray<byte> s, in GrainOccupancyField occ, int cx, int cy, int sx, int sy, int cap, int oxMin, int oxMax, int oyMin)
		{
			return 0;
		}

		private static bool PathClear(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy, int i, int j, int oxMin, int oxMax, int oyMin)
		{
			return false;
		}

		public static void ResolveOccupancy(ref float2 p, ref float2 v, in GrainOccupancyField occ, NativeArray<byte> snapshot, float sdt)
		{
		}

		private static float2 NearestFreeDirPic(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy, int oxMin, int oxMax, int oyMin)
		{
			return default;
		}

		private static bool OccAt(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy, int oxMin, int oxMax, int oyMin)
		{
			return false;
		}

		private static bool OccAtSealX(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy, int oxMin, int oxMax, int oyMin)
		{
			return false;
		}

		private static float OccF(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy, int oxMin, int oxMax, int oyMin)
		{
			return 0f;
		}

		public static int ColOfPx(in GrainOccupancyField occ, float px)
		{
			return 0;
		}

		public static float ScrollPyOf(in GrainOccupancyField occ, int col)
		{
			return 0f;
		}

		public static void ColOccBounds(in GrainOccupancyField occ, int col, out int oxMin, out int oxMax)
		{
			oxMin = default;
			oxMax = default;
		}

		public static int RevealOyMin(in GrainOccupancyField occ, int col)
		{
			return 0;
		}

		private static float2 SmoothNormalWorld(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy, int oxMin, int oxMax, int oyMin)
		{
			return default;
		}

		public static float2 BuildNormalAt(NativeArray<byte> s, in GrainOccupancyField occ, int ox, int oy)
		{
			return default;
		}
	}
}
