using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class RandomSwipePlayer : ALevelSimPlayer
	{
		private const int CornersMin = 1;

		private const int CornersMax = 4;

		private const int SegLenMin = 2;

		private const int SegLenMax = 5;

		private const int CarefulCorners = 1;

		private const int CarefulSegLen = 2;

		private static readonly Vector2Int[] Dirs;

		private readonly List<int> _sandCells;

		public override LevelSimPlan PlanMove(LevelSimState state, LevelSimPolicy.FrontierGrid grid, LevelSimParams p, System.Random rng, int moveIndex)
		{
			return default;
		}
	}
}
