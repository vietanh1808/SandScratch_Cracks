using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstRoute : JBase
	{
		public List<Dictionary<int, int>> MoveHistograms { get; }

		public List<List<Vector2Int>> Paths { get; }

		public Dictionary<int, int> TotalPixelsByColor { get; }

		public int Moves { get; set; }

		public string StopReason { get; set; }

		public int UncoveredPixels { get; set; }

		public int VirtualJarClears { get; set; }

		public float GrainsPerPixelDivisor { get; set; }
	}
}
