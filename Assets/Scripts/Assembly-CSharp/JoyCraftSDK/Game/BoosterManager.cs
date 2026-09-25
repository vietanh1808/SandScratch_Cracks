using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	public class BoosterManager : ABoosterManager
	{
		[FormerlySerializedAs("datas")]
		[SerializeField]
		private BuyBoosterData[] buyBoosterDatas;

		private List<IBooster> boosterInstance;

		private IBooster currentBooster;

		private BoosterType currentUnlockedBooster;

		private BoosterType currentTryBuyBoosterType;

		private bool isTutorial;

		private readonly Dictionary<BoosterType, int> temporaryCharges;

		private bool isExecutingEffect;

		private readonly HashSet<BoosterType> _adRewardedThisLevel;

		public override bool IsExecutingEffect => false;

		public override BoosterType GetExecutingBooster()
		{
			return BoosterType.None;
		}

		public override void TryExecute(BoosterType type)
		{
		}

		public override void RevokeExecution()
		{
		}

		public override void CompleteExecution()
		{
		}

		public override int GetBoosterUnlockLevel(BoosterType type)
		{
			return 0;
		}

		public override void ApplyUnlock(BoosterType type, int initialQuantity)
		{
		}

		public override int GetBoosterCount(BoosterType type)
		{
			return 0;
		}

		public override void AddBoosterCount(BoosterType type, int count, BoosterEarnReason reason, AnalyticsPlacement placement)
		{
		}

		public override void ConsumeBooster(BoosterType type, int amount = 1)
		{
		}

		public override void AddTemporaryCharge(BoosterType type, int amount)
		{
		}

		public override void ClearTemporaryCharges()
		{
		}

		public override int GetTemporaryCharge(BoosterType type)
		{
			return 0;
		}

		public override BoosterType GetPreviousUnlockedBooster()
		{
			return BoosterType.None;
		}

		public override BoosterType GetTryBuyBoosterType()
		{
			return BoosterType.None;
		}

		public override BuyBoosterData GetBuyBoosterData(BoosterType type)
		{
			return null;
		}

		public override int GetBoosterPrice()
		{
			return 0;
		}

		public override int GetBuyBoosterQuantity()
		{
			return 0;
		}

		public override bool IsTutorial()
		{
			return false;
		}

		public override bool CanAdRewardBooster(BoosterType type)
		{
			return false;
		}

		public override void MarkBoosterAdRewarded(BoosterType type)
		{
		}

		private void InitBooster()
		{
		}

		private IBooster GetBoosterInstance(BoosterType type)
		{
			return null;
		}

		private void OnSetupScene(ref AEventManager.OnSetupScene eventData)
		{
		}

		private void OnExecuteBooster(ref AEventManager.OnExecuteBooster eventData)
		{
		}

		private void OnCompleteBoosterExecution(ref AEventManager.OnCompleteBoosterExecution eventData)
		{
		}

		private void OnLevelUnloaded(ref AEventManager.OnLevelUnloaded eventData)
		{
		}

		private void OnStartTestScene(ref AEventManager.OnStartTestScene eventData)
		{
		}

		private void TryExecuteTutorialBooster(ref AEventManager.OnTryExecuteTutorialBooster eventData)
		{
		}

		private void OnTryBuyBooster(ref AEventManager.OnTryBuyBooster eventData)
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
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
