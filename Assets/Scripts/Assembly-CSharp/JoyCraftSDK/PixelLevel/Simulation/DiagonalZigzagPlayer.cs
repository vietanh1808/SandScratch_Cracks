using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class DiagonalZigzagPlayer : ALevelSimPlayer
	{
		private readonly LevelSimStrategy _strategy;

		private readonly List<Vector2Int> _chain;

		private int _chainRows;

		private int _chainCols;

		private int _cursor;

		public DiagonalZigzagPlayer(LevelSimStrategy strategy)
		{
		}

		public override void BeginRun()
		{
		}

		public override LevelSimPlan PlanMove(LevelSimState state, LevelSimPolicy.FrontierGrid grid, LevelSimParams p, System.Random rng, int moveIndex)
		{
			return default;
		}

		private int FindLeg(LevelSimPolicy.FrontierGrid grid, int[] score, int legCount)
		{
			return 0;
		}

		private bool IsLegEmpty(LevelSimPolicy.FrontierGrid grid, int[] score, int leg)
		{
			return false;
		}

		private void EnsureChain(int rows, int cols)
		{
		}

		private void BuildChain(int rows, int cols)
		{
		}

		private static Vector2Int EdgePoint(int k, int r)
		{
			return default;
		}

		private static Vector2Int BottomPoint(int k, int r, int c)
		{
			return default;
		}
	}
}
