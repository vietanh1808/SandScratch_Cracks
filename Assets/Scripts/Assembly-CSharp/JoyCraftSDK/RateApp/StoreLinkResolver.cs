using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine.Networking;

namespace JoyCraftSDK.RateApp
{
	public class StoreLinkResolver : JBase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAppStoreProductUrlAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			public StoreLinkResolver _003C_003E4__this;

			private UniTask<string>.Awaiter _003C_003Eu__1;

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
		private struct _003CGetAppStoreUrlAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			public StoreLinkResolver _003C_003E4__this;

			private UniTask<string>.Awaiter _003C_003Eu__1;

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
		private struct _003CResolveTrackIdAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<string> _003C_003Et__builder;

			public StoreLinkResolver _003C_003E4__this;

			private string _003CbundleId_003E5__2;

			private UnityWebRequest _003Crequest_003E5__3;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

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

		private string _cachedTrackId;

		public string GetPlayStoreUrl()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAppStoreUrlAsync_003Ed__2))]
		public UniTask<string> GetAppStoreUrlAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CGetAppStoreProductUrlAsync_003Ed__3))]
		public UniTask<string> GetAppStoreProductUrlAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CResolveTrackIdAsync_003Ed__4))]
		private UniTask<string> ResolveTrackIdAsync()
		{
			return default;
		}
	}
}
