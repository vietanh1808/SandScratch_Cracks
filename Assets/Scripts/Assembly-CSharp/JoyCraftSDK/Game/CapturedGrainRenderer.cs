using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class CapturedGrainRenderer : JBase
	{
		private const int BatchMax = 1023;

		private static readonly int ColorProp;

		private static readonly Vector4 FallbackColor;

		private Material _material;

		private Vector4[] _colorLut;

		private Mesh _mesh;

		private MaterialPropertyBlock _mpb;

		private readonly Matrix4x4[] _matrices;

		private readonly Vector4[] _colors;

		public bool IsReady => false;

		public void Build(Material sharedMaterial, Vector4[] colorLut)
		{
		}

		public void Render(CapturedGrainSwarm swarm)
		{
		}

		private void Flush(RenderParams rp, int count)
		{
		}

		public void Dispose()
		{
		}
	}
}
