using DG.Tweening;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class SmokeVfx : ASmokeVfx
	{
		[SerializeField]
		public ParticleSystem glowVfx;

		[SerializeField]
		private Light _glowLighting;

		[SerializeField]
		private float _lightingTime;

		[SerializeField]
		private float _lightingRange;

		private Tweener lightTween;

		public override ParticleSystem GlowVfx => null;

		public override Light PointLight => null;

		public override void PlayLight()
		{
		}
	}
}
