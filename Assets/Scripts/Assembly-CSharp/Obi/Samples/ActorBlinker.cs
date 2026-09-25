using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiActor))]
	public class ActorBlinker : MonoBehaviour
	{
		public Color neutralColor;

		public Color highlightColor;

		private ObiActor actor;

		private void Awake()
		{
		}

		public void Blink(int particleIndex)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
