using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK
{
	public class TimeManager : ATimeManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSyncServerTimeAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TimeManager _003C_003E4__this;

			private DateTime? _003CserverUtc_003E5__2;

			private UniTask<DateTime?>.Awaiter _003C_003Eu__1;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__2;

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
		private float _totalGameTime;

		[SerializeField]
		private float _totalLevelTime;

		[SerializeField]
		[Range(0.1f, 5f)]
		private float _gameSpeed;

		private float _secondAccumulator;

		private bool _isGamePaused;

		private int _pauseCount;

		private TimeSpan _serverTimeOffset;

		private readonly NtpClient _ntpClient;

		private bool _isSyncingServerTime;

		private float _lastSyncRealtime;

		private const float MinResyncIntervalSeconds = 30f;

		public override float GameSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool IsPaused => false;

		public override float TotalGameTime => 0f;

		public override float TotalLevelTime => 0f;

		public override float DeltaTime => 0f;

		public override float FixedDeltaTime => 0f;

		public override DateTime UtcNow => default;

		private void OnSceneStartPlay(ref AEventManager.OnSceneStartPlay eventdata)
		{
		}

		private void OnStartLoadScene(ref AEventManager.OnStartLoadScene eventdata)
		{
		}

		private void OnLevelFinished(ref AEventManager.OnLevelFinished eventData)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnFixedUpdate(ref AEventManager.OnFixedUpdate eventdata)
		{
		}

		public override void ContinueGameTime()
		{
		}

		public override void PauseGameTime()
		{
		}

		public override void ForceResumeGameTime()
		{
		}

		[AsyncStateMachine(typeof(_003CSyncServerTimeAsync_003Ed__35))]
		public override UniTask SyncServerTimeAsync()
		{
			return default;
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}
	}
}
