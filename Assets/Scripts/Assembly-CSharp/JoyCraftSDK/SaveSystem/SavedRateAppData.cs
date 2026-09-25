using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedRateAppData : JSaveData
	{
		public const int MaxVersion_SavedRateAppData = 1;

		[SerializeField]
		private int winsSinceLastPrompt;

		[SerializeField]
		private long lastPromptUtcTicks;

		[SerializeField]
		private int promptCount;

		[SerializeField]
		private string versionLastRated;

		public int WinsSinceLastPrompt => 0;

		public long LastPromptUtcTicks => 0L;

		public int PromptCount => 0;

		public string VersionLastRated => null;

		public override int GetMaxVersion()
		{
			return 0;
		}

		public override List<ISavableData> GetChildrenISavableData()
		{
			return null;
		}

		public void RegisterWin()
		{
		}

		public void RecordPromptShown(long utcTicks, string appVersion)
		{
		}
	}
}
