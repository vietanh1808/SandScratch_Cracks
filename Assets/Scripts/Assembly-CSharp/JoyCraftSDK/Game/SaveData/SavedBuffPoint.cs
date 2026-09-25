using System;

namespace JoyCraftSDK.Game.SaveData
{
	[Serializable]
	public class SavedBuffPoint
	{
		public BuffType type;

		public long startUtcTicks;

		public long durationTicks;

		public float magnitude;
	}
}
