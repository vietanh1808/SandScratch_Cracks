using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstSchedule : JBase
	{
		public List<List<RouteFirstJar>> Columns { get; set; }

		public float PeakStuckFill { get; set; }

		public int PeakStuckMove { get; set; }

		public int PlacedJars { get; set; }

		public int UncoveredPixels { get; set; }

		public int JarCountSpread { get; set; }

		public new List<string> Log { get; }
	}
}
