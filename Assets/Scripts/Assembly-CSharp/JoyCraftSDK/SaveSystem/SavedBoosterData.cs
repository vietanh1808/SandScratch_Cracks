using System;
using System.Collections.Generic;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBoosterData : JSaveData
	{
		public const int MaxVersion_SavedBoosterData = 2;

		[SerializeField]
		private List<SavedBoosterDataPoint> boosterDataPoints;

		[NonSerialized]
		private BoosterEarnReason _pendingEarnReason;

		[NonSerialized]
		private BoosterSpendReason _pendingSpendReason;

		[NonSerialized]
		private AnalyticsPlacement _pendingPlacement;

		public List<SavedBoosterDataPoint> BoosterDataPoint => null;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override bool UpdateVersionIncremental(int currentVersion)
		{
			return false;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public int GetQuantity(BoosterType type)
		{
			return 0;
		}

		public void SetQuantity(BoosterType type, int quantity)
		{
		}

		public void SetQuantity(BoosterType type, int quantity, BoosterEarnReason reason, AnalyticsPlacement placement)
		{
		}

		public void AddQuantity(BoosterType type, int amount, BoosterEarnReason reason, AnalyticsPlacement placement)
		{
		}

		public bool TryConsume(BoosterType type, int amount, BoosterSpendReason reason, AnalyticsPlacement placement)
		{
			return false;
		}

		public void FinishFTUE(BoosterType type)
		{
		}

		public bool IsFTUEShowed(BoosterType type)
		{
			return false;
		}

		public bool TryGrantUnlockGift(BoosterType type, int amount, BoosterEarnReason reason, AnalyticsPlacement placement)
		{
			return false;
		}

		public bool IsUnlockGiftGranted(BoosterType type)
		{
			return false;
		}

		private void MarkUnlockGiftGranted(BoosterType type)
		{
		}
	}
}
