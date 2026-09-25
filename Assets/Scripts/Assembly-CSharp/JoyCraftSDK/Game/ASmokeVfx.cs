using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class ASmokeVfx : JMonoBehaviour
	{
		public abstract ParticleSystem GlowVfx { get; }

		public abstract Light PointLight { get; }

		public abstract void PlayLight();
	}
}
