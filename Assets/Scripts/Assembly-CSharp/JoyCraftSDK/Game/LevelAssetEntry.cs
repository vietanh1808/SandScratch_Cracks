using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelAssetEntry : JBase
	{
		[Tooltip("Addressable ref tới ALevelData asset (dựng qua BuildFromFolder — mark Addressable + guid).")]
		[SerializeField]
		private AssetReference levelRef;

		[Tooltip("Difficulty MIRROR từ LevelData (resident — hỏi KHÔNG cần load asset nặng). Re-sync bằng BuildFromFolder.")]
		[SerializeField]
		private ReleaseDifficulty difficulty;

		[Tooltip("Các bản thay thế chọn qua Remote Config level_variant_overrides (key = slot 1-based).")]
		[SerializeField]
		private List<LevelVariantEntry> variants;

		[Tooltip("Số variant LỚN NHẤT từng cấp cho entry này (V1=base nên variant đầu = 2). Id đã cấp KHÔNG tái dùng kể cả sau khi xoá.")]
		[SerializeField]
		private int lastVariantNumber;

		public AssetReference LevelRef => null;

		public ReleaseDifficulty Difficulty => (ReleaseDifficulty)0;

		public IReadOnlyList<LevelVariantEntry> Variants => null;

		public LevelAssetEntry()
		{
		}

		public LevelAssetEntry(AssetReference levelRef, ReleaseDifficulty difficulty)
		{
		}

		public bool TryGetVariant(string variantId, out AssetReference variantRef)
		{
			variantRef = null;
			return false;
		}

		internal void CopyVariantsFrom(LevelAssetEntry other)
		{
		}
	}
}
