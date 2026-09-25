using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "ColorDefinitionSO", menuName = "JoyCraft/Configs/ColorDefinitionSO")]
	public class ColorDefinitionSO : JScriptableObject
	{
		private const string GROUP_GAMEOBJECTCOLOR = "GameObject Color";

		private const string GROUP_SANDCOLOR = "Sand Color";

		[SerializeField]
		private ColorDefinition objectColor;

		[Tooltip("Material của HIDDEN BOX (box sinh ra giấu màu, chỉ lộ khi lên hàng đầu — ColorJarData.hidden). Bỏ trống -> box ẩn hiện material màu THẬT (lộ bài), có LogError báo.")]
		[SerializeField]
		private Material hiddenObjectMaterial;

		[SerializeField]
		private ColorDefinition_Sand sandColor;

		public Material GetObjectMaterial(GameObjectColor color)
		{
			return null;
		}

		public Material GetHiddenObjectMaterial()
		{
			return null;
		}

		public Color GetSandColor(GameObjectColor color)
		{
			return default;
		}

		public bool TryGetSandColor(GameObjectColor color, out Color sandColorValue)
		{
			sandColorValue = default;
			return false;
		}

		private static Color Opaque(Color c)
		{
			return default;
		}
	}
}
