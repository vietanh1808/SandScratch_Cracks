using System;

namespace JoyCraftSDK.Game.SaveData
{
	[Serializable]
	public class SavedRegenPoint
	{
		public RegenResourceType type;

		public int count;

		public long lastRegenUtcTicks;

		public int maxCountOverride;
	}
}
