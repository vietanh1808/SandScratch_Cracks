using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedTrackData : JSaveData, ISeasonResettable
	{
		public const int MaxVersion_SavedTrackData = 1;

		[SerializeField]
		private List<int> claimedMilestoneIds;

		[SerializeField]
		private bool premiumUnlocked;

		public IReadOnlyList<int> ClaimedMilestoneIds => null;

		public bool PremiumUnlocked => false;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public bool IsClaimed(int milestoneId)
		{
			return false;
		}

		public void RecordClaim(int milestoneId)
		{
		}

		public void ClearClaimed()
		{
		}

		public void SetPremiumUnlocked(bool value)
		{
		}

		public void ResetSeason()
		{
		}
	}
}
