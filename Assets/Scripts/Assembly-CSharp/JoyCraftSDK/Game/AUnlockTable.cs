using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AUnlockTable : JScriptableObject
	{
		public abstract IReadOnlyList<UnlockEntry> GetUnlocksAtLevel(int level);

		public abstract UnlockEntry GetEntry(UnlockableType unlockable);

		public abstract int GetUnlockLevelOf(UnlockableType unlockable);

		public abstract int GetLastRealBoosterUnlockLevel();

		public abstract UnlockEntry GetNextFeatureUnlock(int currentLevel);

		public abstract UnlockEntry GetPreviousFeatureUnlock(int currentLevel);

		public abstract UnlockEntry GetNextBoosterUnlock(int currentLevel);

		public abstract UnlockEntry GetPreviousBoosterUnlock(int currentLevel);

		public abstract UnlockEntry GetNextUnlock(int currentLevel, Func<UnlockEntry, bool> filter = null);

		public abstract UnlockEntry GetPreviousUnlock(int currentLevel, Func<UnlockEntry, bool> filter = null);
	}
}
