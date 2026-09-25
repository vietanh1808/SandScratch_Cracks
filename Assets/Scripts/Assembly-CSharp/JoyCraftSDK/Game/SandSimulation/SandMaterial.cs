using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace JoyCraftSDK.Game.SandSimulation
{
	[Serializable]
	[BurstCompile]
	public struct SandMaterial
	{
		[Tooltip("Logical id. Index 0 of the table MUST be Empty.")]
		public SandMaterialId id;

		[Header("Behaviours (up to 4)")]
		public SandBehaviour behaviour0;

		public SandBehaviour behaviour1;

		public SandBehaviour behaviour2;

		public SandBehaviour behaviour3;

		[Header("Physics")]
		[Tooltip("Density in kg/m^3. Denser materials sink through lighter movable ones (e.g. sand through water).")]
		public float density;

		[Range(0f, 1f)]
		[Tooltip("0 = ice (never stops sliding), 1 = comes to rest instantly.")]
		public float friction;

		[Range(0f, 1f)]
		[Tooltip("Scale on gravity acceleration.")]
		public float gravityScale;

		[Range(0f, 1f)]
		[Tooltip("Fraction of velocity kept on bounce (reserved).")]
		public float bouncyness;

		[SerializeField]
		[Tooltip("Max cells this material can flow per step. Clamped to SandGrid.MaxTravelPerStep.")]
		private int flowSpeed;

		[Header("Start state")]
		[Tooltip("1 = spawns awake and simulating, 0 = spawns asleep.")]
		public byte startsAwake;

		[Header("Color")]
		public SandColorStrategy colorStrategy;

		public Color32 color0;

		[Range(0f, 1f)]
		[Tooltip("Chance a pixel is darkened when using Color0Darken.")]
		public float colorDarkenChanceRatio;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetFlowSpeed()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasBehaviour(SandBehaviour behaviour)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsMovable()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsAffectedByGravity()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetPixelColors(ref Pixel pixel, ref Unity.Mathematics.Random rnd)
		{
		}

		public static SandMaterial CreateSand(SandMaterialId id, Color32 color, float density = 1600f)
		{
			return default;
		}

		public static SandMaterial CreateWall(Color32 color)
		{
			return default;
		}

		public static SandMaterial CreateEmpty()
		{
			return default;
		}
	}
}
