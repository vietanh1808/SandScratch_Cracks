using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;

namespace JoyCraftSDK.Game.SandSimulation
{
	[Serializable]
	[BurstCompile]
	public struct Pixel
	{
		public int materialIndex;

		public byte hasValue;

		public int x;

		public int y;

		public byte r;

		public byte g;

		public byte b;

		public byte a;

		public byte shade;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetColor(byte r, byte g, byte b, byte a)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetColor(byte r, byte g, byte b)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SandMaterial GetMaterial(ref NativeArray<SandMaterial> materials)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float GetDensity(ref NativeArray<SandMaterial> materials)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetFlowSpeed(ref NativeArray<SandMaterial> materials)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasBehaviour(SandBehaviour behaviour, ref NativeArray<SandMaterial> materials)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsMovableOrEmpty(ref NativeArray<SandMaterial> materials)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsMovable(ref NativeArray<SandMaterial> materials)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsAffectedByGravity(ref NativeArray<SandMaterial> materials)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasSameMaterial(ref Pixel pixel)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsDenserThanAndCanBeSwappedWith(ref Pixel pixel, ref NativeArray<SandMaterial> materials)
		{
			return false;
		}
	}
}
