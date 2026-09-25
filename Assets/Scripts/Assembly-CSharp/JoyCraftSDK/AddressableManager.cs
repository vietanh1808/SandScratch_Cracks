using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace JoyCraftSDK
{
	public class AddressableManager : AAddressableManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public AddressableManager _003C_003E4__this;

			public Action onComplete;

			private UniTask<AddressableInitResult>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadInitAssets_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public AddressableManager _003C_003E4__this;

			private IList<IResourceLocation> _003Clocations_003E5__2;

			private UniTask<IList<IResourceLocation>>.Awaiter _003C_003Eu__1;

			private UniTask<long>.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadRemoteAsset_003Ed__11<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public AddressableManager _003C_003E4__this;

			public AssetID assetID;

			private AssetReference _003CassetReference_003E5__2;

			private AsyncOperationHandle<T> _003Chandle_003E5__3;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadRemoteAsset_003Ed__14<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public AddressableManager _003C_003E4__this;

			public AssetReference assetReference;

			private AsyncOperationHandle<T> _003Chandle_003E5__2;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		[Space]
		private AGameAssets gameAssets;

		[SerializeField]
		private ARemoteContentConfig remoteContentConfig;

		[SerializeField]
		private AssetLabelReference initKey;

		private readonly Dictionary<AssetReference, object> _inUseAssets;

		private AssetsDictionary _gameAssetsDictionary => null;

		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public override void Init(Action onComplete = null)
		{
		}

		private void LogInitStatus(AddressableInitResult result)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadInitAssets_003Ed__8))]
		private UniTask<bool> LoadInitAssets()
		{
			return default;
		}

		private bool VerifyAssetIDDict()
		{
			return false;
		}

		protected virtual ARemoteContentManager CreateRemoteContent()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadRemoteAsset_003Ed__11<>))]
		public override UniTask<T> LoadRemoteAsset<T>(AssetID assetID)
		{
			return default;
		}

		public override void UnloadRemoteAsset<T>(AssetID assetID)
		{
		}

		private AssetReference GetAssetReferenceByID(AssetID assetID)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadRemoteAsset_003Ed__14<>))]
		public override UniTask<T> LoadRemoteAsset<T>(AssetReference assetReference)
		{
			return default;
		}

		public override void UnloadRemoteAsset<T>(AssetReference assetReference)
		{
		}
	}
}
