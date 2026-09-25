using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class AAnchorRegistry : JBase
	{
		public abstract void Push(EffectType type, Transform anchor);

		public abstract void Remove(EffectType type, Transform anchor);

		public abstract Transform Get(EffectType type);
	}
}
