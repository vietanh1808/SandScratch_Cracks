using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.Game
{
	public class LevelVariantResolver : JBase
	{
		public const string BaseVariantId = "V1";

		private string _parsedRawJson;

		private int _parsedSlotCount;

		private readonly Dictionary<int, string> _slotToVariantId;

		public AssetReference ResolveLevelRef(LevelAssetEntry entry, int slot, int slotCount, string rawJson, out string variantId)
		{
			variantId = null;
			return null;
		}

		private void EnsureParsed(string rawJson, int slotCount)
		{
		}
	}
}
