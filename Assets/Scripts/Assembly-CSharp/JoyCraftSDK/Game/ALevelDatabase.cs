using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelDatabase : JScriptableObject
	{
		public abstract int LevelCount { get; }

		public abstract ALevelData GetLevel(int level);
	}
}
