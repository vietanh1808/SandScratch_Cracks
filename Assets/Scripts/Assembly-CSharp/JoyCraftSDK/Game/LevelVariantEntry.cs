using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelVariantEntry : JBase
	{
		[Tooltip("Id variant: V2, V3… (V1 = bản gốc, KHÔNG khai ở đây). Đã lên RC thì KHÔNG đổi tên/tái dùng.")]
		[SerializeField]
		private string variantId;

		[Tooltip("Addressable ref tới ALevelData asset của bản variant này.")]
		[SerializeField]
		private AssetReference levelRef;

		public string VariantId => null;

		public AssetReference LevelRef => null;
	}
}
