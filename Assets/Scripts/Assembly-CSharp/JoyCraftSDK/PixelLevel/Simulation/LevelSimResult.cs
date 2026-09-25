using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class LevelSimResult : JBase
	{
		private const int MaxLossCellsListed = 8;

		public int Runs { get; set; }

		public LevelSimStrategy Strategy { get; set; }

		public float WinRate { get; set; }

		public float AvgMoves { get; set; }

		public float AvgEstimatedSeconds { get; set; }

		public float AvgPeakBeltFill { get; set; }

		public float MaxPeakBeltFill { get; set; }

		public Dictionary<LevelSimOutcome, int> FailReasons { get; }

		public int DistinctWinPaths { get; set; }

		public List<LevelSimTrace> Traces { get; set; }

		public Dictionary<LevelSimDeadEndKind, int> DeadEndKinds { get; }

		public List<FrozenGroupStat> FrozenGroupStats { get; }

		public string Summary()
		{
			return null;
		}

		private string FormatLossCells(LevelSimOutcome outcome)
		{
			return null;
		}
	}
}
