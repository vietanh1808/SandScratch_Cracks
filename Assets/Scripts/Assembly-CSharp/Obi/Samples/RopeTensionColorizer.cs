using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiRope))]
	public class RopeTensionColorizer : MonoBehaviour
	{
		public float minTension;

		public float maxTension;

		public Color normalColor;

		public Color tensionColor;

		public RopeTenser tenser;

		public float tenserThreshold;

		public float tenserMax;

		private ObiRope rope;

		private Material localMaterial;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}
