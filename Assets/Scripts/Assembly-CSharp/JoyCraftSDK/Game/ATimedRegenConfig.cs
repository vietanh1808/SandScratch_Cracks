using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedRegenConfig : JScriptableObject
	{
		public abstract IReadOnlyList<TimedRegenConfigPoint> GetConfigPoints();

		public abstract TimedRegenConfigPoint GetConfigPoint(RegenResourceType type);
	}
}
