using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[RequireComponent(typeof(ParticleSystem))]
	public class TrailEffect : JMonoBehaviour
	{
		public TrailRenderer trailPb;

		public TrailEffectData data;

		private ParticleSystem ps;

		private ParticleSystem.Particle[] particles;

		private Dictionary<uint, TrailRenderer> activeTrails;

		private Stack<TrailRenderer> trailPool;

		public override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private Vector3 GetParticleWorldPosition(int index)
		{
			return default;
		}

		private TrailRenderer GetTrailFromPool()
		{
			return null;
		}

		private void ApplyData(TrailRenderer trail, ParticleSystem.Particle particle)
		{
		}

		private void ReturnTrailToPool(TrailRenderer trail)
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
