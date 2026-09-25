using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	public class EasySaveDatabaseService : ASaveDatabaseService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateNewData_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SavedGameData> _003C_003Et__builder;

			public EasySaveDatabaseService _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadGameDataAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SavedGameData> _003C_003Et__builder;

			public EasySaveDatabaseService _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			private UniTask<SavedGameData>.Awaiter _003C_003Eu__3;

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
		private SavedGameData loadedData;

		private readonly float _demoWaitTime;

		protected ES3Settings _settings;

		private const string RecoveryTelemetryEventName = "save_recovery";

		private const string RecoveryTelemetryResultParamKey = "result";

		private const string RecoveryTelemetryExceptionParamKey = "exception";

		private const string RecoveryResultRestored = "restored";

		private const string RecoveryResultWipedNoBackup = "wiped_no_backup";

		private const string RecoveryResultWipedRestoreFailed = "wiped_restore_failed";

		[SerializeField]
		private ALocalDatabaseService easyLocalDatabaseService;

		private string MainDataKey => null;

		public override ALocalDatabaseService LocalDataReloader => null;

		public override UniTask SaveGameData(SavedGameData data)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoadGameDataAsync_003Ed__12))]
		public override UniTask<SavedGameData> LoadGameDataAsync()
		{
			return default;
		}

		protected SavedGameData TryRecoverCorruptedData(Exception e)
		{
			return null;
		}

		protected virtual void EmitRecoveryTelemetry(string result, Exception cause)
		{
		}

		public override UniTask Init(Action onComplete = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CCreateNewData_003Ed__16))]
		private UniTask<SavedGameData> CreateNewData()
		{
			return default;
		}

		private void OnValidate()
		{
		}
	}
}
