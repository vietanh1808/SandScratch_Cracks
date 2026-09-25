using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class ResourceManager : AResourceManager
	{
		private ResourceEarnChannel pendingHeartGainReason;

		private AnalyticsPlacement pendingHeartGainPlacement;

		private AnalyticsPlacement pendingHeartUsePlacement;

		protected virtual SavedPlayerProgressData Progress => null;

		protected virtual int CurrentLevelId => 0;

		private int currentCoin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int currentGem
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int currentStar
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected virtual void RaiseCoinChange(AEventManager.OnCoinChange evt)
		{
		}

		protected virtual void RaiseGemChange(AEventManager.OnGemChange evt)
		{
		}

		public override int GetCoin()
		{
			return 0;
		}

		public override void AddCoin(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement)
		{
		}

		public override bool SpendCoin(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement)
		{
			return false;
		}

		public override int GetStar()
		{
			return 0;
		}

		public override void AddStar(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement)
		{
		}

		public override bool SpendStar(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement)
		{
			return false;
		}

		public override int GetGem()
		{
			return 0;
		}

		public override void AddGem(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement)
		{
		}

		public override bool SpendGem(int amount, ResourceSpendChannel reason, AnalyticsPlacement placement)
		{
			return false;
		}

		public override int GetHeartCount()
		{
			return 0;
		}

		public override int GetMaxHeart()
		{
			return 0;
		}

		public override void SetMaxHeart(int maxHeart)
		{
		}

		public override void AddHeart(int amount, ResourceEarnChannel reason, AnalyticsPlacement placement)
		{
		}

		public override bool UseHeart(int amount, AnalyticsPlacement placement)
		{
			return false;
		}

		public override void SetInfiniteHeart(float duration)
		{
		}

		public override bool IsInfiniteHeartActive()
		{
			return false;
		}

		public override float GetInfiniteHeartRemainingSeconds()
		{
			return 0f;
		}

		public override float GetSecondsUntilNextHeart()
		{
			return 0f;
		}

		public override void ApplyPendingRegen()
		{
		}

		private void OnTimedRegenChangeHandler(ref AEventManager.OnTimedRegenChange eventData)
		{
		}

		private void OnTimedBuffExpiredHandler(ref AEventManager.OnTimedBuffExpired eventData)
		{
		}

		private void OnReceiveFinishLevelCoin(ref AEventManager.OnReceiveFinishLevelCoin eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
