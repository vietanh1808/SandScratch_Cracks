using System.Runtime.CompilerServices;
using Unity.Collections;

namespace JoyCraftSDK.Game.SandSimulation
{
	public struct SandGrid
	{
		public const int MaxTravelPerStep = 6;

		public NativeArray<Pixel> Pixels;

		public NativeArray<SandMaterial> Materials;

		public int Width;

		public int Height;

		public bool IsCreated => false;

		public SandGrid(int width, int height, SandMaterial[] materials, Allocator allocator)
		{
			Pixels = default;
			Materials = default;
			Width = 0;
			Height = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Index(int x, int y)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool InBounds(int x, int y)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Pixel Get(int x, int y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(int x, int y, in Pixel pixel)
		{
		}

		public void Dispose()
		{
		}
	}
}
