using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JTD.Logic;

namespace JTD
{
	internal sealed class JTDEventQueue
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CExecuteRevenue_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EventContext rev;

			public JTDEventQueue _003C_003E4__this;

			private IEnumerator<RevenueOp> _003C_003E7__wrap1;

			private UniTask<JTDClient.SendResult>.Awaiter _003C_003Eu__1;

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
		private struct _003CFlushBatchOnce_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public JTDEventQueue _003C_003E4__this;

			public CancellationToken ct;

			private int _003Cattempt_003E5__2;

			private UniTask<JTDClient.SendResult>.Awaiter _003C_003Eu__1;

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
		private struct _003CFlushOnce_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public JTDEventQueue _003C_003E4__this;

			public CancellationToken ct;

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
		private struct _003CResendLeftoverRevenue_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public JTDEventQueue _003C_003E4__this;

			public CancellationToken ct;

			private List<EventContext> _003Crevenue_003E5__2;

			private int _003Ctake_003E5__3;

			private int _003Cidx_003E5__4;

			private EventContext _003Crev_003E5__5;

			private UniTask<JTDClient.SendResult>.Awaiter _003C_003Eu__1;

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
		private struct _003CRunFlushLoop_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken ct;

			public JTDEventQueue _003C_003E4__this;

			private UniTask<int>.Awaiter _003C_003Eu__1;

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

		internal const string KeyQueue = "jtd_queue";

		internal const string KeyQueueVersion = "jtd_queue_version";

		internal const int QueueVersion = 1;

		private const int FlushIntervalSec = 5;

		private const int FlushSoftCount = 100;

		private const int MaxBatch = 500;

		private readonly JTDClient _client;

		private readonly IJTDHost _host;

		private readonly bool _verbose;

		private readonly bool _sendEnabled;

		private readonly Action _onBeforePersist;

		private readonly List<EventContext> _queue;

		private List<EventContext> _inFlight;

		private bool _flushing;

		private bool _did429Wait;

		private UniTaskCompletionSource _wakeTcs;

		private readonly HashSet<string> _revenueInFlightIds;

		private const int ResendRevenueCapPerCycle = 5;

		internal JTDEventQueue(JTDClient client, IJTDHost host, bool verbose = false, bool sendEnabled = true, Action onBeforePersist = null)
		{
		}

		internal void Start()
		{
		}

		internal void Enqueue(EventContext ctx)
		{
		}

		[AsyncStateMachine(typeof(_003CRunFlushLoop_003Ed__20))]
		private UniTask RunFlushLoop(CancellationToken ct)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CFlushOnce_003Ed__21))]
		internal UniTask FlushOnce(CancellationToken ct)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CFlushBatchOnce_003Ed__22))]
		private UniTask FlushBatchOnce(CancellationToken ct)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CExecuteRevenue_003Ed__23))]
		private UniTaskVoid ExecuteRevenue(EventContext rev)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CResendLeftoverRevenue_003Ed__25))]
		private UniTask ResendLeftoverRevenue(CancellationToken ct)
		{
			return default;
		}

		private void RaiseIapVerifyCallback(EventContext rev, JTDClient.SendResult send, bool raiseOnNoVerdict = true)
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void PersistQueue()
		{
		}

		private void RestoreQueue()
		{
		}

		private List<EventContext> TakeBatch(int max)
		{
			return null;
		}

		private void PrependRange(List<EventContext> items)
		{
		}

		private void DropPoison(IReadOnlyList<string> poisonIds)
		{
		}

		private void RemoveById(string id)
		{
		}

		private int RetryAfterDelayMs(JTDClient.SendResult send, int attempt)
		{
			return 0;
		}

		private void Wake()
		{
		}

		internal void RequestFlush()
		{
		}

		private static IReadOnlyList<string> QueueIds(List<EventContext> q)
		{
			return null;
		}

		private static IReadOnlyDictionary<string, int> PerItemRetryCounts(List<EventContext> items)
		{
			return null;
		}

		private void LogDrop(JTDClient.SendResult send)
		{
		}

		private void ClearInFlightAndPersist()
		{
		}

		private static double Rand01()
		{
			return 0.0;
		}
	}
}
