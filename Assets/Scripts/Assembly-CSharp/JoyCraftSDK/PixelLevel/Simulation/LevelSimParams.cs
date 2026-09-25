using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public class LevelSimParams : JBase
	{
		public int Seed { get; set; }

		public int Runs { get; set; }

		public int MaxMoves { get; set; }

		public int NoProgressMoves { get; set; }

		public LevelSimStrategy Strategy { get; set; }

		public float IntentProbabilityStart { get; set; }

		public float IntentProbabilityEnd { get; set; }

		public float OvershootProbability { get; set; }

		public float WeightSweep { get; set; }

		public float WeightUpwardDrag { get; set; }

		public float WeightOneBend { get; set; }

		public float WeightTwoBend { get; set; }

		public float WeightScrub { get; set; }

		public float WeightArc { get; set; }

		public float WeightTap { get; set; }

		public int SweepLenMin { get; set; }

		public int DragLenMin { get; set; }

		public int DragLenMax { get; set; }

		public int BendSegLenMin { get; set; }

		public int BendSegLenMax { get; set; }

		public int ScrubBoxMin { get; set; }

		public int ScrubBoxMax { get; set; }

		public int ArcLenMin { get; set; }

		public int ArcLenMax { get; set; }

		public int BrushRadiusPx { get; set; }

		public int CellSizePx { get; set; }

		public int SlideCellsPx { get; set; }

		public float BeltFullEntry { get; set; }

		public float AimPrecision { get; set; }

		public int LookaheadJars { get; set; }

		public float BeltFeedForceFill { get; set; }

		public float SecondsPerMove { get; set; }

		public int BeltCapacityGrains { get; set; }

		public float GrainsPerPixelDivisor { get; set; }
	}
}
