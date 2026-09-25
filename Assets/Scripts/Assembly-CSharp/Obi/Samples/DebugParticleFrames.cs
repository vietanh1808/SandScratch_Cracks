using UnityEngine;

namespace Obi.Samples
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(ObiActor))]
	public class DebugParticleFrames : MonoBehaviour
	{
		private ObiActor actor;

		public float size;

		public void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
