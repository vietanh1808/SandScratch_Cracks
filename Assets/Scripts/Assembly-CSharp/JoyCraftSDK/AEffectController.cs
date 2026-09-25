using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class AEffectController : JMonoBehaviour
	{
		public abstract void Play(EffectType type, Transform target, Action onDone = null);

		public abstract void Play(EffectType type, Vector3 targetPosition, Action onDone = null);
	}
}
