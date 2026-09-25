using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstRunner : JBase
	{
		public RouteFirstReport Run(LevelData level, LevelSimStrategy strategy, RouteFirstParams routeFirstParams, LevelSimParams baseParams, SandFlowConfig cfg, int stochasticRuns)
		{
			return null;
		}

		public static LevelSimParams MakeSimParams(LevelSimStrategy strategy, int runs, int seed, LevelSimParams baseParams, int beltCapacityGrains)
		{
			return null;
		}

		public static List<LevelSimResult> Validate(LevelData level, List<ColorJarColumnData> columns, IList<LevelSimParams> simParams, SandFlowConfig cfg)
		{
			return null;
		}

		public static List<ColorJarColumnData> BuildColumns(RouteFirstSchedule schedule)
		{
			return null;
		}
	}
}
