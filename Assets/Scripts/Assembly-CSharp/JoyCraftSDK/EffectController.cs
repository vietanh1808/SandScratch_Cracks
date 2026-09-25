using System;
using System.Collections.Generic;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace JoyCraftSDK
{
	public class EffectController : AEffectController
	{
		[SerializeField]
		private AEffectDatabase effectDatabase;

		private readonly Dictionary<EffectType, AWinEffect> spawnedEffects;

		private AWinEffect GetOrSpawn(EffectType type)
		{
			return null;
		}

		public override void Play(EffectType type, Transform target, Action onDone = null)
		{
		}

		public override void Play(EffectType type, Vector3 targetPosition, Action onDone = null)
		{
		}
	}
}
