using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RouteFirstRecorder : JBase
	{
		public RouteFirstRoute Record(LevelData level, LevelSimParams p, SandFlowConfig cfg, int columnCount, int jarCapacity)
		{
			return null;
		}

		private RouteFirstRoute RecordOnCopy(LevelData copy, LevelSimParams p, SandFlowConfig cfg, int columnCount, int jarCapacity)
		{
			return null;
		}

		private static void ApplyVirtualJarClears(LevelSimState state, RouteFirstRoute route, LevelSimMove move, int jarCapacity, Dictionary<int, int> releasedByColor, Dictionary<int, int> virtualClearedByColor)
		{
		}

		internal static float ResolveDivisor(LevelSimParams p, SandFlowConfig cfg)
		{
			return 0f;
		}
	}
}
