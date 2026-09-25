using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	[Serializable]
	public class RouteFirstScore : JBase
	{
		public float WorstPeak;

		public int OverflowRuns;

		public float AvgPeak;

		public int TotalRuns;

		public int DetWins;

		public int DetCount;

		public float HumanLikeWinRate;

		public float RandomWinRate;

		public long ElapsedMs;

		public string Line()
		{
			return null;
		}
	}
}
