using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class StrokeGenerator : JBase
	{
		public struct Stroke
		{
			public List<Vector2Int> Waypoints;

			public string Name;
		}

		public Stroke Generate(Vector2Int target, int cols, int rows, LevelSimParams p, System.Random rng)
		{
			return default;
		}

		private string PickPresetName(LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private List<Vector2Int> GenerateSweep(Vector2Int target, int cols, LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private List<Vector2Int> GenerateUpwardDrag(Vector2Int target, LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private List<Vector2Int> GenerateOneBend(Vector2Int target, LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private List<Vector2Int> GenerateTwoBend(Vector2Int target, LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private List<Vector2Int> GenerateScrub(Vector2Int target, LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private List<Vector2Int> GenerateArc(Vector2Int target, LevelSimParams p, System.Random rng)
		{
			return null;
		}

		private static Vector2Int DirFromAngle(float radians)
		{
			return default;
		}
	}
}
