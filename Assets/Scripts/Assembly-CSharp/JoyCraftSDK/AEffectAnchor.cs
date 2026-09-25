using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class AEffectAnchor : JMonoBehaviour
	{
		[SerializeField]
		protected List<EffectType> types;

		protected void Register()
		{
		}

		protected void Unregister()
		{
		}
	}
}
