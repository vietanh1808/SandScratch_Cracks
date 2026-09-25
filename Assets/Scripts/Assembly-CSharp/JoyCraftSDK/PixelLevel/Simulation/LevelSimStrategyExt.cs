namespace JoyCraftSDK.PixelLevel.Simulation
{
	public static class LevelSimStrategyExt
	{
		public static bool IsDeterministic(this LevelSimStrategy s)
		{
			return false;
		}

		public static bool StartsFromLeft(this LevelSimStrategy s)
		{
			return false;
		}
	}
}
