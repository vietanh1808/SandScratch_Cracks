using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class GrainInstancedRenderer : JBase
	{
		private const int BatchMax = 1023;

		private const string ShaderName = "SandFlow/GrainInstanced";

		private static readonly int ColorProp;

		private static readonly int GrainScaleProp;

		private static readonly int BorderWidthProp;

		private static readonly int BorderAlphaProp;

		private static readonly Vector4 FallbackColor;

		public static int RenderPasses;

		private GrainParticlePool _pool;

		private Vector4[] _colorLut;

		private Mesh _mesh;

		private Material _material;

		private bool _ownMaterial;

		private MaterialPropertyBlock _mpb;

		private readonly Matrix4x4[] _matrices;

		private readonly Vector4[] _colors;

		private static bool _prewarmed;

		private static bool _fpFirstRenderDone;

		private static int _fpArmFrame;

		private static Mesh _sharedQuad;

		public Material Material => null;

		public float GhostZOffset { get; set; }

		public void Build(GrainParticlePool pool, Vector4[] colorLut, Material overrideMaterial = null, Material styleSource = null)
		{
		}

		public void Prewarm()
		{
		}

		public void SetMaterial(Material mat)
		{
		}

		private static void CopyStyle(Material src, Material dst)
		{
		}

		public void Render()
		{
		}

		private void Flush(RenderParams rp, int count)
		{
		}

		public void Dispose()
		{
		}

		public static Mesh BuildGrainQuad()
		{
			return null;
		}
	}
}
