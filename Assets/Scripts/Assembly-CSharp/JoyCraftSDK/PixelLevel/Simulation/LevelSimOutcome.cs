using System;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	[Serializable]
	public enum LevelSimOutcome
	{
		None = 0,
		Win = 1,
		BeltOverflow = 2,
		NoLegalMove = 3,
		MaxMovesReached = 4,
		NoProgress = 5
	}
}
