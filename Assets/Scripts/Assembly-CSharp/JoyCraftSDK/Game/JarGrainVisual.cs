using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class JarGrainVisual : JMonoBehaviour
	{
		[Tooltip("Renderer của grain — SpriteRenderer (sprite) HOẶC MeshRenderer (sphere...). Bỏ trống -> tự GetComponent.")]
		[SerializeField]
		private Renderer grainRenderer;

		private static readonly int BaseColorProp;

		private static readonly int ColorProp;

		private MaterialPropertyBlock _propertyBlock;

		public void SetColor(Color color)
		{
		}

		public void SetVisible(bool visible)
		{
		}
	}
}
