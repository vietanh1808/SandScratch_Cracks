using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class LevelSimMove : JBase
	{
		public int Index { get; set; }

		public string StrokeName { get; set; }

		public LevelSimIntent Intent { get; set; }

		public List<Vector2Int> Path { get; set; }

		public List<Vector2Int> Carved { get; }

		public int ConvertedPixels { get; set; }

		public int GrainsAdded { get; set; }

		public int AimSkippedPixels { get; set; }

		public int GrainsDrained { get; set; }

		public float BeltFillAfter { get; set; }

		public bool HadMatchAtChoice { get; set; }

		public float BeltFillBefore { get; set; }

		public int JarsCompletedAfter { get; set; }

		public int[] ScrollRowsAfter { get; set; }

		public Dictionary<int, int> ConvertedByColor { get; }
	}
}
