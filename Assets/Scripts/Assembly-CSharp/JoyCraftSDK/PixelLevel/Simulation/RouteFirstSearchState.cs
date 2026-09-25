using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	[Serializable]
	public class RouteFirstSearchState : JBase
	{
		public string LevelName;

		public int Seed;

		public int MaxMoves;

		public int NoProgressMoves;

		public int BeltCapacityGrains;

		public int JarCapacity;

		public int ColumnCount;

		public int ScreenHumanLike;

		public int ScreenRandom;

		public int HeldOutHumanLike;

		public int HeldOutRandom;

		public int HeldOutSeedOffset;

		public float HumanLikeWinRateFilter;

		public int HillClimbRounds;

		public List<LevelSimStrategy> RequiredStrategies;

		public List<RouteFirstCandidate> Candidates;

		public new List<string> Log;
	}
}
