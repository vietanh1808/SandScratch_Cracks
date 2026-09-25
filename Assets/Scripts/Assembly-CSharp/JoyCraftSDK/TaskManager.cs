using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace JoyCraftSDK
{
	public class TaskManager : ATaskManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDoAfterFrameAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public uint frame;

			public CancellationToken cancellationToken;

			public Action action;

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
		private struct _003CDoAfterSecondsAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public float seconds;

			public bool ignoreTimescale;

			public CancellationToken cancellationToken;

			public Action action;

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
		private struct _003CDoAfterSecondsUnsafeAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public float seconds;

			public bool ignoreTimescale;

			public CancellationToken cancellationToken;

			public Action action;

			public Action<Exception> onException;

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
		private struct _003CDoEndOfFrameAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public MonoBehaviour caller;

			public Action action;

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
		private struct _003CDoWhenAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Func<bool> predicate;

			public Action action;

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

		public override void DoAfterSeconds(float seconds, Action action, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		public override void DoAfterRealSeconds(float seconds, Action action, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		[AsyncStateMachine(typeof(_003CDoAfterSecondsAsync_003Ed__2))]
		private UniTaskVoid DoAfterSecondsAsync(float seconds, Action action, bool ignoreTimescale, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		public override void DoAfterSecondsUnsafe(float seconds, Action action, Action<Exception> onException)
		{
		}

		public override void DoAfterRealSecondsUnsafe(float seconds, Action action, Action<Exception> onException)
		{
		}

		[AsyncStateMachine(typeof(_003CDoAfterSecondsUnsafeAsync_003Ed__5))]
		private static UniTaskVoid DoAfterSecondsUnsafeAsync(float seconds, Action action, Action<Exception> onException, bool ignoreTimescale, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		public override void DoNextFrame(Action action, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		public override void DoAfterFrames(uint count, Action action, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		[AsyncStateMachine(typeof(_003CDoAfterFrameAsync_003Ed__8))]
		private UniTaskVoid DoAfterFrameAsync(uint frame, Action action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default;
		}

		public override void DoEndOffFrame(Action action, MonoBehaviour caller = null)
		{
		}

		[AsyncStateMachine(typeof(_003CDoEndOfFrameAsync_003Ed__10))]
		private UniTaskVoid DoEndOfFrameAsync(Action action, MonoBehaviour caller)
		{
			return default;
		}

		public override void DoWhen(Func<bool> predicate, Action action)
		{
		}

		[AsyncStateMachine(typeof(_003CDoWhenAsync_003Ed__12))]
		private UniTaskVoid DoWhenAsync(Func<bool> predicate, Action action)
		{
			return default;
		}

		public void Awake()
		{
		}
	}
}
