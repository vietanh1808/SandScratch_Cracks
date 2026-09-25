using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	public class EasyLocalDatabaseService : ALocalDatabaseService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateNewData_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SavedGameData> _003C_003Et__builder;

			public EasyLocalDatabaseService _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadGameDataAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SavedGameData> _003C_003Et__builder;

			public EasyLocalDatabaseService _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<SavedGameData>.Awaiter _003C_003Eu__2;

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
		private struct _003CSaveAndReloadData_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SavedGameData> _003C_003Et__builder;

			public EasyLocalDatabaseService _003C_003E4__this;

			public SavedGameData newData;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private UniTask<SavedGameData>.Awaiter _003C_003Eu__2;

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
		private struct _003CSaveGameData_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public SavedGameData data;

			public EasyLocalDatabaseService _003C_003E4__this;

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

		[SerializeField]
		private SavedGameData loadedData;

		private bool _inited;

		private ES3Settings _settings;

		private string MainDataKey => null;

		public override void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CSaveAndReloadData_003Ed__6))]
		public override UniTask<SavedGameData> SaveAndReloadData(SavedGameData newData)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSaveGameData_003Ed__7))]
		private UniTask<bool> SaveGameData(SavedGameData data)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CLoadGameDataAsync_003Ed__8))]
		private UniTask<SavedGameData> LoadGameDataAsync()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CCreateNewData_003Ed__9))]
		private UniTask<SavedGameData> CreateNewData()
		{
			return default;
		}

		private void Init(Action onComplete = null)
		{
		}
	}
}
