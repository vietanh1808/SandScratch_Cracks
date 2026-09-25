using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using VContainer;

namespace JoyCraftSDK.SaveSystem
{
	public class GameDataManager : AGameDataManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInit_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameDataManager _003C_003E4__this;

			public Action onComplete;

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
		private struct _003CLoadGameDataAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameDataManager _003C_003E4__this;

			public Action onComplete;

			private UniTask<SavedGameData>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CPreProcessAfterLoad_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameDataManager _003C_003E4__this;

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
		private struct _003CPreProcessBeforeSave_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameDataManager _003C_003E4__this;

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
		private struct _003CSaveAndReloadDataAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameDataManager _003C_003E4__this;

			public Action onComplete;

			private UniTask<SavedGameData>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private struct _003CSaveGameData_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameDataManager _003C_003E4__this;

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

		private ASaveDatabaseService _database;

		private bool _databaseInited;

		private bool _inited;

		private ALocalDatabaseService localDatabaseService => null;

		public double CurrentPlanetCumulativeBooster { get; protected set; }

		[Inject]
		public void Construct(ASaveDatabaseService database)
		{
		}

		[AsyncStateMachine(typeof(_003CInit_003Ed__10))]
		public override UniTask Init(Action onComplete = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSaveGameData_003Ed__11))]
		private UniTask SaveGameData()
		{
			return default;
		}

		public override void SaveGameDataAndForget()
		{
		}

		[AsyncStateMachine(typeof(_003CSaveAndReloadDataAsync_003Ed__13))]
		public override UniTask SaveAndReloadDataAsync(Action onComplete = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoadGameDataAsync_003Ed__14))]
		private UniTask LoadGameDataAsync(Action onComplete = null)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPreProcessBeforeSave_003Ed__15))]
		private UniTask PreProcessBeforeSave()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPreProcessAfterLoad_003Ed__16))]
		private UniTask PreProcessAfterLoad()
		{
			return default;
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}

		protected override void OnApplicationQuit()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnSceneExit(ref AEventManager.OnSceneExit eventData)
		{
		}

		private void OnSceneExitSaveLogoutTime(SceneIndex toExit, SceneIndex toEnter)
		{
		}

		private void SetupScene(ref AEventManager.OnSetupScene eventData)
		{
		}

		private void OnSceneStartPlay(ref AEventManager.OnSceneStartPlay eventData)
		{
		}

		private void InitUserId()
		{
		}

		private bool ShouldSaveDataOnQuit()
		{
			return false;
		}

		private void SetupSavedDataOnQuit()
		{
		}
	}
}
