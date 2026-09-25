using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ALiveEventManager : JBase
	{
		public abstract string EventId { get; }

		public virtual bool IsActive => false;

		public virtual bool IsUnlocked => false;

		protected abstract RewardTrack Track { get; }

		protected abstract JSaveData EventSaveData { get; }

		public abstract void Initialize();

		protected virtual void SaveState()
		{
		}

		public bool CanClaim(int milestoneId)
		{
			return false;
		}

		protected bool CanClaimUngated(int milestoneId)
		{
			return false;
		}

		protected virtual bool IsClaimGated(int milestoneId)
		{
			return false;
		}

		public bool IsTierUnlocked(int tier)
		{
			return false;
		}

		public int GetTierStepCost(int tier)
		{
			return 0;
		}

		public int GetTierUnlockCost(int tier)
		{
			return 0;
		}

		public bool TryClaim(int milestoneId)
		{
			return false;
		}

		public virtual void ResetSeason()
		{
		}

		private void ResetChildrenRecursive(List<ISavableData> children)
		{
		}

		protected virtual void RaiseMilestoneClaimed(int milestoneId)
		{
		}

		protected virtual void RaiseCurrencyChanged(int earned)
		{
		}
	}
}
