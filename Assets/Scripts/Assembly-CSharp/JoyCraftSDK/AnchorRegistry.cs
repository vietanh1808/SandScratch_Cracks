using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK
{
	public class AnchorRegistry : AAnchorRegistry
	{
		private readonly Dictionary<EffectType, List<Transform>> stacks;

		public override void Push(EffectType type, Transform anchor)
		{
		}

		public override void Remove(EffectType type, Transform anchor)
		{
		}

		public override Transform Get(EffectType type)
		{
			return null;
		}

		private List<Transform> GetOrCreate(EffectType type)
		{
			return null;
		}
	}
}
