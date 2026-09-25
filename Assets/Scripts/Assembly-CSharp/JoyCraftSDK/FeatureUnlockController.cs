using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public class FeatureUnlockController : AFeatureUnlockController
	{
		private GameFeatureType currentUnlockedFeature;

		public override GameFeatureType CurrentLockedFeature => GameFeatureType.None;

		public override GameFeatureType PreviousUnlockedFeature => GameFeatureType.None;

		public override void ApplyUnlock(GameFeatureType type)
		{
		}

		public override float GetCurrentFeatureProgress()
		{
			return 0f;
		}

		public override float GetUpdatedFeatureProgress()
		{
			return 0f;
		}

		public override void UnlockNewFeature(GameFeatureType type)
		{
		}

		private float ComputeProgress(int levelOffset)
		{
			return 0f;
		}
	}
}
