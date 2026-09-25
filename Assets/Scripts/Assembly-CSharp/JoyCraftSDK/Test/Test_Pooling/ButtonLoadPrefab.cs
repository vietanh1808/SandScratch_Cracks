using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.Test.Test_Pooling
{
	public class ButtonLoadPrefab : JButton
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnClick_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ButtonLoadPrefab _003C_003E4__this;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
		private AssetReference prefabReference;

		[SerializeField]
		private Transform parentTransform;

		[AsyncStateMachine(typeof(_003COnClick_003Ed__2))]
		protected override void OnClick()
		{
		}
	}
}
