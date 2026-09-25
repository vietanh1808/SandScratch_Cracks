using System;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class HumanLikePlayer : ALevelSimPlayer
	{
		private readonly LevelSimPolicy _policy;

		private readonly StrokeGenerator _strokeGen;

		public HumanLikePlayer(LevelSimPolicy sharedPolicy)
		{
		}

		public override LevelSimPlan PlanMove(LevelSimState state, LevelSimPolicy.FrontierGrid grid, LevelSimParams p, Random rng, int moveIndex)
		{
			return default;
		}
	}
}
