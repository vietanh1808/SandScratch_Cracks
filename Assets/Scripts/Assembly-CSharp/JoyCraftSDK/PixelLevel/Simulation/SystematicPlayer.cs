using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class SystematicPlayer : ALevelSimPlayer
	{
		private readonly LevelSimStrategy _strategy;

		private readonly bool _isVertical;

		private int _cursor;

		public SystematicPlayer(LevelSimStrategy strategy)
		{
		}

		public override void BeginRun()
		{
		}

		public override LevelSimPlan PlanMove(LevelSimState state, LevelSimPolicy.FrontierGrid grid, LevelSimParams p, System.Random rng, int moveIndex)
		{
			return default;
		}

		private int FindLine(LevelSimPolicy.FrontierGrid grid, int[] score, int lineCount)
		{
			return 0;
		}

		private bool IsLineEmpty(LevelSimPolicy.FrontierGrid grid, int[] score, int lineCursor)
		{
			return false;
		}

		private static int RowFromK(int rows, int k)
		{
			return 0;
		}

		private static int RowIndexFromCursor(int rows, int cursor)
		{
			return 0;
		}

		private int ColumnIndexFromCursor(int cols, int cursor)
		{
			return 0;
		}

		private List<Vector2Int> BuildWaypoints(LevelSimState state, int cursor)
		{
			return null;
		}
	}
}
