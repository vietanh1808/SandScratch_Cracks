namespace JoyCraftSDK.Utilities
{
	public static class UnlockableTypeMapping
	{
		private const int BoosterBandStart = 1;

		private const int BoosterBandEnd = 99;

		private const int FeatureBandStart = 100;

		private const int FeatureBandEnd = 199;

		public static BoosterType ToBoosterType(this UnlockableType unlockable)
		{
			return BoosterType.None;
		}

		public static GameFeatureType ToFeatureType(this UnlockableType unlockable)
		{
			return GameFeatureType.None;
		}

		public static UnlockableType ToUnlockable(this BoosterType type)
		{
			return UnlockableType.None;
		}

		public static UnlockableType ToUnlockable(this GameFeatureType type)
		{
			return UnlockableType.None;
		}

		public static bool IsBooster(this UnlockableType unlockable)
		{
			return false;
		}

		public static bool IsFeature(this UnlockableType unlockable)
		{
			return false;
		}
	}
}
