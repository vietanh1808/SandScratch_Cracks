using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AEffectDatabase : JScriptableObject
	{
		public abstract AWinEffect GetPrefab(EffectType type);
	}
}
