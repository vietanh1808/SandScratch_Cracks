using TouchScript.Layers;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Examples.Cube
{
	public class LayerDelegate : MonoBehaviour, ILayerDelegate
	{
		public RedirectInput Source;

		public TouchLayer RenderTextureLayer;

		public bool ShouldReceivePointer(TouchLayer layer, IPointer pointer)
		{
			return false;
		}
	}
}
