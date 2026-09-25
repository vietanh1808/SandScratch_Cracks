using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	[Serializable]
	[CreateAssetMenu(fileName = "GameAssets", menuName = "JoyCraft/Scriptable Objects/Addressable Assets/Game Assets")]
	public class GameAssets : AGameAssets
	{
		[SerializeField]
		private AssetsDictionary assets;

		[SerializeField]
		private int assetIDDictionaryExactLength;

		public override AssetsDictionary Assets => null;

		public override int AssetIDDictionaryExactLength => 0;
	}
}
