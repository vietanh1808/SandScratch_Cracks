using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiActor))]
	public class ColorFromVelocity : MonoBehaviour
	{
		private ObiActor actor;

		public float sensibility;

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
