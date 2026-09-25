using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstParams : JBase
	{
		public int JarCapacity { get; set; }

		public int ColumnCount { get; set; }

		public int BeltCapacityGrains { get; set; }

		public RouteFirstColumnPolicy ColumnPolicy { get; set; }

		public int HiddenCount { get; set; }

		public RouteFirstRouteSource Source { get; set; }
	}
}
