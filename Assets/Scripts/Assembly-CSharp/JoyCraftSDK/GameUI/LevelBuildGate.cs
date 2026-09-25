using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GenericEventBus;
using JoyCraftSDK.Game;

namespace JoyCraftSDK.GameUI
{
	public static class LevelBuildGate
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public UniTaskCompletionSource built;

			public int level;

			public bool loadFailed;

			public GateVerdict failReason;

			public long failDownloadSizeBytes;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitBuilt_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int level;

			public GenericEventBus<IEvent> eventBus;

			public Action startLoad;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			public Action retryLoad;

			private bool _003CtimedOut_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

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

		private const float MaxWaitSeconds = 10f;

		private const string RetryOfflineMessage = "No internet connection. Please connect to load this level.";

		private const string RetryFailedMessage = "Failed to load level. Please try again!";

		private const string RetryLabel = "Retry";

		private const string ConsentMessageFormat = "This level needs an extra {0:F1} MB download.";

		public const string ConsentLabel = "Download";

		private const string ProgressMessageFormat = "Downloading {0:F1}/{1:F1} MB";

		private static bool _progressPopupOpen;

		public static string BuildRetryMessage(bool offline)
		{
			return null;
		}

		public static string BuildConsentMessage(long downloadSizeBytes)
		{
			return null;
		}

		public static string BuildProgressMessage(long downloadedBytes, long totalBytes)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWaitBuilt_003Ed__11))]
		public static UniTask WaitBuilt(GenericEventBus<IEvent> eventBus, Action startLoad, int level = 0, Action retryLoad = null)
		{
			return default;
		}

		public static Action ResolveRetryLoad(Action startLoad, Action retryLoad)
		{
			return null;
		}

		public static void InvokeRetry(GenericEventBus<IEvent> eventBus, Action startLoad, Action retryLoad, int level)
		{
		}

		private static void ShowRetryPopup(GenericEventBus<IEvent> eventBus, Action startLoad, int level, Action retryLoad)
		{
		}

		private static void ShowConsentPopup(GenericEventBus<IEvent> eventBus, Action startLoad, int level, long downloadSizeBytes, Action retryLoad)
		{
		}

		private static void ReportDownloadProgress(long downloadedBytes, long totalBytes)
		{
		}

		private static void CloseProgressPopupIfOpen()
		{
		}
	}
}
