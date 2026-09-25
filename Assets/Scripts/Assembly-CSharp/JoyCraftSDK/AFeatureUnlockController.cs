using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AFeatureUnlockController : JMonoBehaviour
	{
		public abstract GameFeatureType CurrentLockedFeature { get; }

		public abstract GameFeatureType PreviousUnlockedFeature { get; }

		public abstract void ApplyUnlock(GameFeatureType type);

		public abstract float GetCurrentFeatureProgress();

		public abstract float GetUpdatedFeatureProgress();

		public abstract void UnlockNewFeature(GameFeatureType type);
	}
}
