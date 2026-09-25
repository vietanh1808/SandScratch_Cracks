using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.RateApp
{
	public class SimulatorReviewRequester : JBase, IReviewRequester
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COpenStoreForReview_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SimulatorReviewRequester _003C_003E4__this;

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

		private readonly StoreLinkResolver _storeLinkResolver;

		public bool IsAvailable => false;

		public void RequestReview()
		{
		}

		[AsyncStateMachine(typeof(_003COpenStoreForReview_003Ed__4))]
		private UniTaskVoid OpenStoreForReview()
		{
			return default;
		}
	}
}
