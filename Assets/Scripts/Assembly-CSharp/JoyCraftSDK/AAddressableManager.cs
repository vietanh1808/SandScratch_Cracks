using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK
{
	public abstract class AAddressableManager : JMonoBehaviour
	{
		public AddressableInitResult InitResult { get; protected set; }

		public ARemoteContentManager RemoteContent { get; protected set; }

		public abstract void Init(Action onComplete = null);

		public abstract UniTask<T> LoadRemoteAsset<T>(AssetID assetID);

		public abstract void UnloadRemoteAsset<T>(AssetID id);

		public abstract UniTask<T> LoadRemoteAsset<T>(AssetReference assetReference);

		public abstract void UnloadRemoteAsset<T>(AssetReference assetReference);
	}
}
