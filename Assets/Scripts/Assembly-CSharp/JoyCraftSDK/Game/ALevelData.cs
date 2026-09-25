using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelData : JScriptableObject
	{
		public abstract ReleaseDifficulty ReleaseDifficulty { get; }

		public abstract PixelLevelData PixelLevelData { get; }

		public virtual bool GrainyLook => false;

		public virtual List<ColorJarColumnData> ColorJarColumns => null;
	}
}
