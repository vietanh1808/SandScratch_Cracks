using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class TestScreenSampleAddressables : JUIPanel
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoad50mbTextBtnClick_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TestScreenSampleAddressables _003C_003E4__this;

			private UniTask<TextAsset>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadDuckBtnClick_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TestScreenSampleAddressables _003C_003E4__this;

			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadOggBtnClick_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TestScreenSampleAddressables _003C_003E4__this;

			private UniTask<AudioClip>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadSampleTextBtnClick_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TestScreenSampleAddressables _003C_003E4__this;

			private UniTask<TextAsset>.Awaiter _003C_003Eu__1;

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

		private const string Group_Assets = "Asset References";

		private const string Group_Buttons = "Buttons";

		[SerializeField]
		private AssetReference duckImage;

		[SerializeField]
		private AssetReference textFile;

		[SerializeField]
		private AssetReference largeFile;

		[SerializeField]
		private AssetReference music;

		[SerializeField]
		private AudioSource audioManager;

		[SerializeField]
		private ABtnEvents loadDuckBtn;

		[SerializeField]
		private ABtnEvents loadOggBtn;

		[SerializeField]
		private ABtnEvents loadSampleTextBtn;

		[SerializeField]
		private ABtnEvents load50mbTextBTn;

		[SerializeField]
		private ABtnEvents unloadDuckBtn;

		[SerializeField]
		private ABtnEvents unloadOggBtn;

		[SerializeField]
		private ABtnEvents unloadSampleTextBtn;

		[SerializeField]
		private ABtnEvents unload50mbTextBTn;

		[SerializeField]
		private Image duckImageSprite;

		[AsyncStateMachine(typeof(_003CLoadDuckBtnClick_003Ed__16))]
		private void LoadDuckBtnClick()
		{
		}

		private void unLoadDuckBtnClick()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadOggBtnClick_003Ed__18))]
		private void LoadOggBtnClick()
		{
		}

		private void unLoadOggBtnClick()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadSampleTextBtnClick_003Ed__20))]
		private void LoadSampleTextBtnClick()
		{
		}

		private void unLoadSampleTextBtnClick()
		{
		}

		[AsyncStateMachine(typeof(_003CLoad50mbTextBtnClick_003Ed__22))]
		private void Load50mbTextBtnClick()
		{
		}

		private void unLoad50mbTextBtnClick()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public override UIPanelID GetId()
		{
			return UIPanelID.None;
		}
	}
}
