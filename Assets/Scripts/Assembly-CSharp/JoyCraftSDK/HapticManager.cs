using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Lofelt.NiceVibrations;

namespace JoyCraftSDK
{
	public class HapticManager : AHapticManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayRapidHapticsAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public HapticManager _003C_003E4__this;

			public HapticPatterns.PresetType preset;

			public float interval;

			public CancellationToken ct;

			public float duration;

			private float _003Celapsed_003E5__2;

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

		private const float MinPlayInterval = 0.05f;

		private CancellationTokenSource _rapidHapticCts;

		private float _lastPlayTime;

		private bool isHapticEnabled => false;

		public override void Awake()
		{
		}

		private bool CanPlay(bool respectThrottle)
		{
			return false;
		}

		private void PlayPreset(HapticPatterns.PresetType preset, bool respectThrottle = true)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void InstallDebugOverlay()
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void ReportToOverlay(string label)
		{
		}

		private void OnButtonTryClicked(ref AEventManager.OnButtonTryClicked eventData)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		private void OnJarSealed(ref AEventManager.OnJarSealed eventData)
		{
		}

		private void OnSandSwipeStamp(ref AEventManager.OnSandSwipeStamp eventData)
		{
		}

		public override void PlayRapidHaptics(HapticPatterns.PresetType preset, float duration, float interval = 0.08f)
		{
		}

		[AsyncStateMachine(typeof(_003CPlayRapidHapticsAsync_003Ed__15))]
		private UniTaskVoid PlayRapidHapticsAsync(HapticPatterns.PresetType preset, float duration, float interval, CancellationToken ct)
		{
			return default;
		}

		public override void StopRapidHaptics()
		{
		}

		public override void Light()
		{
		}

		public override void Medium()
		{
		}

		public override void Heavy()
		{
		}

		public override void Success()
		{
		}

		public override void Warning()
		{
		}

		public override void Failure()
		{
		}

		public override void Selection()
		{
		}

		public override void Rigid()
		{
		}

		public override void Soft()
		{
		}

		public override void Emphasis(float amplitude, float frequency = 0.5f)
		{
		}

		public override void Emphasis()
		{
		}

		public override void Constant(float amplitude, float frequency = 0.5f, float duration = 0.5f)
		{
		}

		public override void Constant()
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
