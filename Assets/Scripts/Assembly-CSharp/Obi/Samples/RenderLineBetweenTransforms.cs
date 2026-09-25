using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(LineRenderer))]
	public class RenderLineBetweenTransforms : MonoBehaviour
	{
		public Transform transformA;

		public Transform transformB;

		private LineRenderer line;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
