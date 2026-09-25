using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public class LoadSceneManager : ALoadSceneManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadAdditiveSceneAsync_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public string sceneName;

			public LoadSceneManager _003C_003E4__this;

			public Action onComplete;

			private Awaitable.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadSceneAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public LoadSceneManager _003C_003E4__this;

			public SceneIndex sceneIndex;

			private Stopwatch _003CloadStopwatch_003E5__2;

			private AsyncOperation _003CasyncLoad_003E5__3;

			private AsyncOperation _003CasyncUnloadUnusedAssets_003E5__4;

			private UniTask.Awaiter _003C_003Eu__1;

			private Awaitable.Awaiter _003C_003Eu__2;

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
		private struct _003CPostLoadCleanupAndEvents_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public LoadSceneManager _003C_003E4__this;

			public SceneIndex sceneIndex;

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
		private struct _003CStartInitProgress_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public LoadSceneManager _003C_003E4__this;

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
		private struct _003CUnloadAdditiveSceneAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public string sceneName;

			public LoadSceneManager _003C_003E4__this;

			public Action onComplete;

			private Awaitable.Awaiter _003C_003Eu__1;

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

		private const float LoadSceneSpeed = 2f;

		private const float LoadSceneFinishSpeed = 2f;

		private const float UnityStopProgress = 0.9f;

		private const float FirstWaitToLoad = 0.1f;

		private const float WaitFromLoadSceneFinishToSceneActivation = 2f;

		private const float INIT_PROGRESS_MAX = 0.3f;

		private const float SMOOTH_SPEED = 0.8f;

		private readonly Dictionary<SceneIndex, Action> _sceneLoadedSpecialAction;

		private float displayProgress;

		private bool NeedToInitLoading { get; set; }

		protected new AGuiManager _guiManager => null;

		private AScenesManager _scenesManager => null;

		private void SetSceneAction(SceneIndex sceneIndex, Action action)
		{
		}

		public override void LoadSingleSceneAsNew(SceneIndex toExit, SceneIndex toEnter, Action actionOnLoadFinish = null)
		{
		}

		[AsyncStateMachine(typeof(_003CStartInitProgress_003Ed__19))]
		public override UniTaskVoid StartInitProgress()
		{
			return default;
		}

		public override void OnInitComplete()
		{
		}

		private void LoadScene(SceneIndex sceneIndex, Action actionOnLoadFinish = null, bool overrideNullAction = false)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadSceneAsync_003Ed__22))]
		private UniTaskVoid LoadSceneAsync(SceneIndex sceneIndex)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CPostLoadCleanupAndEvents_003Ed__23))]
		private UniTask PostLoadCleanupAndEvents(SceneIndex sceneIndex)
		{
			return default;
		}

		public override void LoadAdditiveScene(SceneIndex sceneIndex, Action onComplete = null)
		{
		}

		public override void UnloadAdditiveScene(SceneIndex sceneIndex, Action onComplete = null)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAdditiveSceneAsync_003Ed__26))]
		private UniTaskVoid LoadAdditiveSceneAsync(string sceneName, Action onComplete)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CUnloadAdditiveSceneAsync_003Ed__27))]
		private UniTaskVoid UnloadAdditiveSceneAsync(string sceneName, Action onComplete)
		{
			return default;
		}
	}
}
