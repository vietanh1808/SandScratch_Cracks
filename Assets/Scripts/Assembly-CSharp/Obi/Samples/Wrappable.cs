using UnityEngine;

namespace Obi.Samples
{
	public class Wrappable : MonoBehaviour
	{
		private bool wrapped;

		public Color normalColor;

		public Color wrappedColor;

		private Material localMaterial;

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void Reset()
		{
		}

		public void SetWrapped()
		{
		}

		public bool IsWrapped()
		{
			return false;
		}
	}
}
