using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AResourceManager : JMonoBehaviour
	{
		public abstract int GetCoin();

		public abstract void AddCoin(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement);

		public abstract bool SpendCoin(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement);

		public abstract int GetStar();

		public abstract void AddStar(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement);

		public abstract bool SpendStar(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement);

		public abstract int GetGem();

		public abstract void AddGem(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement);

		public abstract bool SpendGem(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement);

		public abstract int GetHeartCount();

		public abstract int GetMaxHeart();

		public abstract void SetMaxHeart(int maxHeart);

		public abstract void AddHeart(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement);

		public abstract bool UseHeart(int amount, AnalyticsPlacement placement);

		public abstract void SetInfiniteHeart(float duration);

		public abstract bool IsInfiniteHeartActive();

		public abstract float GetInfiniteHeartRemainingSeconds();

		public abstract float GetSecondsUntilNextHeart();

		public abstract void ApplyPendingRegen();
	}
}
