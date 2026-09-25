using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public class SceneUISetup : ASceneUISetup
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDisableLoadingWhenBuilt_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SceneUISetup _003C_003E4__this;

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

		private void GameSceneSetup(SceneIndex scene)
		{
		}

		[AsyncStateMachine(typeof(_003CDisableLoadingWhenBuilt_003Ed__1))]
		private UniTaskVoid DisableLoadingWhenBuilt()
		{
			return default;
		}

		private void OnSceneStartPlay(ref AEventManager.OnSceneStartPlay eventdata)
		{
		}

		private void ClearGUI(ref AEventManager.OnBeforeLoadSceneActionInvoked eventdata)
		{
		}

		private void StartLoadingUI(ref AEventManager.OnStartLoadScene eventdata)
		{
		}

		private void OnTestScene(ref AEventManager.OnStartTestScene eventdata)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
