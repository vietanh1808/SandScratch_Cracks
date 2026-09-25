using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedAdGateData : JSaveData, ISeasonResettable
	{
		public const int MaxVersion_SavedAdGateData = 4;

		[SerializeField]
		private int claimedFreeTiersAtLastAdReset;

		[SerializeField]
		private bool baselineSeeded;

		public int ClaimedFreeTiersAtLastAdReset => 0;

		public bool BaselineSeeded => false;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public override bool UpdateVersionIncremental(int currentVersion)
		{
			return false;
		}

		public void SeedBaseline(int claimedFreeTierCount)
		{
		}

		public void ClearGate(int claimedFreeTierCount)
		{
		}

		public void ResetSeason()
		{
		}
	}
}
