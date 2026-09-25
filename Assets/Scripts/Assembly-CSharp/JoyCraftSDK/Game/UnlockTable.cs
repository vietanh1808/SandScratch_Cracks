using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	[Serializable]
	[CreateAssetMenu(fileName = "UnlockTable", menuName = "GameSDK/UnlockTable")]
	public class UnlockTable : AUnlockTable
	{
		[FormerlySerializedAs("entries")]
		[SerializeField]
		private List<UnlockEntry> unlockEntries;

		private static readonly List<UnlockEntry> EmptyEntries;

		public const int NeverUnlockLevel = 9999;

		private Dictionary<int, List<UnlockEntry>> byLevel;

		private Dictionary<UnlockableType, UnlockEntry> byUnlockable;

		private List<int> sortedLevels;

		public override IReadOnlyList<UnlockEntry> GetUnlocksAtLevel(int level)
		{
			return null;
		}

		public override UnlockEntry GetEntry(UnlockableType unlockable)
		{
			return null;
		}

		public override int GetUnlockLevelOf(UnlockableType unlockable)
		{
			return 0;
		}

		public override int GetLastRealBoosterUnlockLevel()
		{
			return 0;
		}

		public override UnlockEntry GetNextFeatureUnlock(int currentLevel)
		{
			return null;
		}

		public override UnlockEntry GetPreviousFeatureUnlock(int currentLevel)
		{
			return null;
		}

		public override UnlockEntry GetNextBoosterUnlock(int currentLevel)
		{
			return null;
		}

		public override UnlockEntry GetPreviousBoosterUnlock(int currentLevel)
		{
			return null;
		}

		public override UnlockEntry GetNextUnlock(int currentLevel, Func<UnlockEntry, bool> filter = null)
		{
			return null;
		}

		public override UnlockEntry GetPreviousUnlock(int currentLevel, Func<UnlockEntry, bool> filter = null)
		{
			return null;
		}

		private static UnlockEntry FirstMatch(List<UnlockEntry> candidates, Func<UnlockEntry, bool> filter)
		{
			return null;
		}

		private void EnsureBuilt()
		{
		}
	}
}
