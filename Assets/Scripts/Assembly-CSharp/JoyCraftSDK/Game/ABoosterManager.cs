using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ABoosterManager : JMonoBehaviour
	{
		public abstract bool IsExecutingEffect { get; }

		public abstract BoosterType GetExecutingBooster();

		public abstract void TryExecute(BoosterType type);

		public abstract void RevokeExecution();

		public abstract void CompleteExecution();

		public abstract int GetBoosterUnlockLevel(BoosterType type);

		public abstract void ApplyUnlock(BoosterType type, int initialQuantity);

		public abstract int GetBoosterCount(BoosterType type);

		public abstract void AddBoosterCount(BoosterType type, int count, BoosterEarnReason reason, AnalyticsPlacement placement);

		public abstract void ConsumeBooster(BoosterType type, int amount = 1);

		public abstract void AddTemporaryCharge(BoosterType type, int amount);

		public abstract void ClearTemporaryCharges();

		public abstract int GetTemporaryCharge(BoosterType type);

		public abstract BoosterType GetPreviousUnlockedBooster();

		public abstract BoosterType GetTryBuyBoosterType();

		public abstract BuyBoosterData GetBuyBoosterData(BoosterType type);

		public abstract int GetBoosterPrice();

		public abstract int GetBuyBoosterQuantity();

		public abstract bool IsTutorial();

		public abstract bool CanAdRewardBooster(BoosterType type);

		public abstract void MarkBoosterAdRewarded(BoosterType type);
	}
}
