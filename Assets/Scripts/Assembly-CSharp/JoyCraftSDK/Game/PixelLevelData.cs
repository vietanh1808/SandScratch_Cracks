using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class PixelLevelData : JBase
	{
		public const int MinColumnCount = 1;

		public const int MaxColumnCount = 4;

		public const float FixedCornerRadiusRatio = 0.025f;

		public const int FixedNoSwipeBandHeight = 15;

		[SerializeField]
		private int width;

		[SerializeField]
		private int height;

		[SerializeField]
		private int[] indices;

		[SerializeField]
		private Color32[] sourceColors;

		[SerializeField]
		[Range(0f, 0.5f)]
		private float cornerRadiusRatio;

		[SerializeField]
		private int viewportHeight;

		[SerializeField]
		private int noSwipeBandHeight;

		[SerializeField]
		private int columnCount;

		[SerializeField]
		private List<FrozenPlacementData> frozenShapes;

		[SerializeField]
		private List<PixelColorRemap> colorRemaps;

		[SerializeField]
		private List<PixelClusterColorMap> clusterColorMaps;

		[SerializeField]
		private string sourcePngGuid;

		[SerializeField]
		private string viewPngGuid;

		public int Width => 0;

		public int Height => 0;

		public float CornerRadiusRatio => 0f;

		public string SourcePngGuid => null;

		public string ViewPngGuid => null;

		public int ViewportHeight => 0;

		public int NoSwipeBandHeight => 0;

		public IReadOnlyList<PixelColorRemap> ColorRemaps => null;

		public bool HasColorRemaps => false;

		public IReadOnlyList<PixelClusterColorMap> ClusterColorMaps => null;

		public IReadOnlyList<FrozenPlacementData> FrozenShapes => null;

		public bool HasFrozenShapes => false;

		public int ColumnCount => 0;

		public bool HasScroll => false;

		public int CornerRadiusCells => 0;

		public bool HasSourceColors => false;

		public void SetPngGuids(string sourceGuid, string viewGuid)
		{
		}

		public bool IsCornerCulled(int x, int y)
		{
			return false;
		}

		public bool InBounds(int x, int y)
		{
			return false;
		}

		public int IndexFlat(int x, int y)
		{
			return 0;
		}

		public int GetIndex(int x, int y)
		{
			return 0;
		}

		public int GetIndexRounded(int x, int y)
		{
			return 0;
		}

		public Color32 GetSourceColor(int x, int y)
		{
			return default;
		}

		public void SetScrollConfig(int vh, int bandHeight, int k)
		{
		}

		public void ResetScrollConfig()
		{
		}

		public void AddFrozenShape(FrozenPlacementData placement)
		{
		}

		public bool RemoveFrozenShape(FrozenPlacementData placement)
		{
			return false;
		}

		public void ClearFrozenShapes()
		{
		}

		public bool SetColorRemap(int from, int to)
		{
			return false;
		}

		public bool AssignGlobalColor(int from, int to)
		{
			return false;
		}

		public bool SetRegionColorRemap(int seedX, int seedY, int from, int to)
		{
			return false;
		}

		public bool SetCellColorRemap(int x, int y, int to)
		{
			return false;
		}

		public bool RemoveColorRemapAt(int index)
		{
			return false;
		}

		public void ClearColorRemaps()
		{
		}

		public void ClearRegionColorRemaps()
		{
		}

		public int GetClusterColorValue(int packedRgb)
		{
			return 0;
		}

		public void SetClusterColorValue(int packedRgb, int value)
		{
		}

		public bool RemoveClusterColorValue(int packedRgb)
		{
			return false;
		}

		public void ClearClusterColorValues()
		{
		}

		public int ResolveColorRemap(int value)
		{
			return 0;
		}

		public void Resize(int w, int h)
		{
		}

		public void SetIndex(int x, int y, int value)
		{
		}

		public void SetAll(int[] source)
		{
		}

		public void SetAllSourceColors(Color32[] source)
		{
		}

		public int[] GetIndicesClone()
		{
			return null;
		}
	}
}
