using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class SmokeEffect : JMonoBehaviour
	{
		public SmokeEffectData data;

		public ParticleSystem mainFx;

		public ParticleSystem[] smokeFxs;

		public MeshRenderer fillMesh;

		public float fillRange;

		public void Setup(Color color)
		{
		}

		public void Setup(GameObjectColor color)
		{
		}

		public void Play()
		{
		}

		private void SetupFill(float progress)
		{
		}

		public void PlayAtProgress(float progress)
		{
		}
	}
}
