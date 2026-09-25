using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedBuffConfig : JScriptableObject
	{
		public abstract IReadOnlyList<TimedBuffConfigPoint> GetConfigPoints();

		public abstract TimedBuffConfigPoint GetConfigPoint(BuffType type);
	}
}
