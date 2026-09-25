using System.Collections.Generic;
using System.Text;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstReport : JBase
	{
		public RouteFirstRoute Route { get; set; }

		public RouteFirstSchedule Schedule { get; set; }

		public LevelSimResult SameStrategyResult { get; set; }

		public LevelSimResult HumanLikeResult { get; set; }

		public LevelSimResult RandomResult { get; set; }

		public List<ColorJarColumnData> SynthesizedColumns { get; set; }

		public int HiddenApplied { get; set; }

		public string Summary()
		{
			return null;
		}

		private static void AppendResult(StringBuilder sb, string label, LevelSimResult result)
		{
		}
	}
}
