using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class LevelSimulator : JBase
	{
		public LevelSimResult Run(LevelData level, LevelSimParams p, SandFlowConfig cfg)
		{
			return null;
		}

		private LevelSimTrace RunOne(LevelData level, LevelSimParams p, SandFlowConfig cfg, int runIndex, LevelSimPolicy policy, ALevelSimPlayer player)
		{
			return null;
		}

		private static void StampLossCell(LevelSimTrace trace)
		{
		}

		private static string BuildPathHash(LevelSimTrace trace)
		{
			return null;
		}

		private LevelSimResult BuildResult(List<LevelSimTrace> traces, LevelSimStrategy strategy)
		{
			return null;
		}
	}
}
