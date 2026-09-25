using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class LevelSimTrace : JBase
	{
		public int RunIndex { get; set; }

		public int Seed { get; set; }

		public LevelSimOutcome Outcome { get; set; }

		public List<LevelSimMove> Moves { get; }

		public float EstimatedSeconds { get; set; }

		public float PeakBeltFill { get; set; }

		public string PathHash { get; set; }

		public Vector2Int LossCell { get; set; }

		public int LossMoveIndex { get; set; }

		public LevelSimDeadEndKind DeadEndKind { get; set; }

		public int JarsLeftAtEnd { get; set; }

		public List<FrozenGroupDiag> FrozenGroups { get; }
	}
}
