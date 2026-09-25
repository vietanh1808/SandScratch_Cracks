using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class LevelSimPolicy : JBase
	{
		public class FrontierGrid : JBase
		{
			public int Cols;

			public int Rows;

			public int[] FrontierScore;

			public int[] MatchScore;

			public int[] UpcomingScore;

			public bool HasFrontier;
		}

		public LevelSimIntent LastIntent { get; private set; }

		public bool LastHadMatch { get; private set; }

		public FrontierGrid ComputeGrid(LevelSimState state)
		{
			return null;
		}

		public Vector2Int ChooseTarget(FrontierGrid grid, LevelSimParams p, System.Random rng, int moveIndex, float beltFill)
		{
			return default;
		}

		private static bool HasAnyPositive(int[] scores)
		{
			return false;
		}

		private Vector2Int? WeightedPick(int[] scores, int cols, int rows, System.Random rng, bool biasLowerRows)
		{
			return null;
		}
	}
}
