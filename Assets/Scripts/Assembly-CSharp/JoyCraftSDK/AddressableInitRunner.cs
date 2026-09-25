using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace JoyCraftSDK
{
	public static class AddressableInitRunner
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public Func<UniTask> initializeAddressables;

			public bool initialized;

			public Func<UniTask<bool>> loadInitAssets;

			public Func<bool> verifyDict;

			public bool dictValid;

			public Action<string> onError;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AddressableInitResult> _003C_003Et__builder;

			public Func<UniTask> initializeAddressables;

			public Func<UniTask<bool>> loadInitAssets;

			public Func<bool> verifyDict;

			public Action<string> onError;

			public Func<UniTask> timeoutSourceOverride;

			public float timeoutSeconds;

			private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

			private UniTask<int>.Awaiter _003C_003Eu__1;

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

		public const float DefaultTimeoutSeconds = 15f;

		[AsyncStateMachine(typeof(_003CRunAsync_003Ed__1))]
		public static UniTask<AddressableInitResult> RunAsync(Func<UniTask> initializeAddressables, Func<UniTask<bool>> loadInitAssets, Func<bool> verifyDict, Action<string> onError, float timeoutSeconds = 15f, Func<UniTask> timeoutSourceOverride = null)
		{
			return default;
		}
	}
}
