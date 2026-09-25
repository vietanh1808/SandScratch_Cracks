using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ATextController : JBase
	{
		public abstract string GetTextLevel();

		public abstract string GetTextLevelTime(float remainingTimeInSeconds);

		public abstract string GetFeatureName(GameFeatureType feature);

		public abstract string GetBoosterName(BoosterType boosterType);

		public abstract string GetBoosterNoTargetText();

		public abstract string GetUnlockBoosterTitle();

		public abstract string GetUnlockFeatureTitle();

		public abstract string GetUnlockFeatureDescription(GameFeatureType feature);

		public abstract string GetUnlockBoosterDescription(BoosterType boosterType);

		public abstract string GetFeedbackSentMessage();
	}
}
