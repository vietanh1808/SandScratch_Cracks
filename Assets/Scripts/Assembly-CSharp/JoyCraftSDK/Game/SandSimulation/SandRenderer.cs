using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace JoyCraftSDK.Game.SandSimulation
{
	public class SandRenderer
	{
		private const float ShadeMin = 0.82f;

		private const float ShadeRange = 0.3f;

		public static readonly byte NeutralShade;

		private static readonly int MainTexStId;

		public static long SessionStagingPeak;

		private readonly int _width;

		private readonly int _height;

		private readonly GameObject _quadRoot;

		private readonly Material _material;

		private readonly List<Transform> _scrollNodes;

		private readonly List<Transform> _quads;

		private MaterialPropertyBlock _mpb;

		private Vector2 _quadSize;

		private NativeArray<byte> _colorBuffer;

		private Texture2D _stagingTex;

		private bool _partialUploadSupported;

		private bool _disposed;

		private bool _deadUseReported;

		private bool _oobReported;

		public Texture2D Texture { get; private set; }

		public int ColumnCount => 0;

		public Transform QuadTransform => null;

		public Transform QuadRootTransform => null;

		public Transform GetQuadTransform(int col)
		{
			return null;
		}

		public Transform GetScrollNode(int col)
		{
			return null;
		}

		public SandRenderer(int width, int height, Transform parent, Material material)
		{
		}

		public void SetColumnCount(int columnCount)
		{
		}

		private void ApplyColumnLayout()
		{
		}

		public void SetScroll(int col, float localY)
		{
		}

		private static Material DefaultMaterial()
		{
			return null;
		}

		public void MatchCamera(Camera camera, float depth = 10f)
		{
		}

		public void SetQuadLocalSize(Vector2 size)
		{
		}

		public void PlaceAt(Vector3 worldCenter, Quaternion rotation, Vector2 worldSize)
		{
		}

		public void SetQuadRootLocalPose(Vector3 localPosition, Quaternion localRotation, Vector3 localScale)
		{
		}

		public void Redraw(in SandGrid grid)
		{
		}

		public void Redraw(in SandGrid grid, int minX, int minY, int maxX, int maxY)
		{
		}

		public void DrawOverlay(int cellX, int cellY, Color32 color, int radius = 0)
		{
		}

		public void Present()
		{
		}

		private void UploadFull()
		{
		}

		public void PresentRegion(int minY, int maxY)
		{
		}

		private void EnsureStaging(int minHeight)
		{
		}

		private bool IsDeadSurface(string caller)
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
