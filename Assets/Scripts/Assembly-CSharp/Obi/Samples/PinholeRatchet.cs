using UnityEngine;

namespace Obi.Samples
{
	public class PinholeRatchet : MonoBehaviour
	{
		public ObiPinhole pinhole;

		public bool direction;

		public float teethSeparation;

		public float distanceToNextTooth { get; private set; }

		private void Update()
		{
		}

		public void OnDisable()
		{
		}
	}
}
