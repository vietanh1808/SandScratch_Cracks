using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public struct LevelSimPlan
	{
		public LevelSimIntent Intent;

		public string StrokeName;

		public List<Vector2Int> Waypoints;

		public bool GiveUp;
	}
}
