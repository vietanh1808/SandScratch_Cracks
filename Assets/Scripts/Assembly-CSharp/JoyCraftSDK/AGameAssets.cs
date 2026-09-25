using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AGameAssets : JScriptableObject
	{
		public abstract AssetsDictionary Assets { get; }

		public abstract int AssetIDDictionaryExactLength { get; }
	}
}
