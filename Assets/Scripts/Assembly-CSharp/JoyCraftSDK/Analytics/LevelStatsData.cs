using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	[Serializable]
	public class LevelStatsData : JBase
	{
		public string SessionId;

		public Dictionary<BoosterType, int> BoostersUsage;

		public List<int> MoveSequence;

		public void Reset()
		{
		}
	}
}
