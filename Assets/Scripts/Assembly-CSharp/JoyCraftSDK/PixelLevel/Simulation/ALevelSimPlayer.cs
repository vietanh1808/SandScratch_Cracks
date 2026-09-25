using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public abstract class ALevelSimPlayer : JBase
	{
		private const int NoKey = -2147483648;

		private readonly HashSet<int> _deadKeys;

		private int _lastKey;

		private int _lastSolidCount;

		private int _lastJarsCompleted;

		public virtual void BeginRun()
		{
		}

		public abstract LevelSimPlan PlanMove(LevelSimState state, LevelSimPolicy.FrontierGrid grid, LevelSimParams p, Random rng, int moveIndex);

		protected void ResetProgressTracking()
		{
		}

		protected void ObserveProgress(LevelSimState state)
		{
		}

		protected bool IsDead(int key)
		{
			return false;
		}

		protected void RememberKey(int key)
		{
		}

		private static int CleanupKey(int cellIndex)
		{
			return 0;
		}

		protected LevelSimPlan PlanCleanup(LevelSimPolicy.FrontierGrid grid)
		{
			return default;
		}

		public static ALevelSimPlayer Create(LevelSimStrategy strategy, LevelSimPolicy sharedPolicy)
		{
			return null;
		}
	}
}
