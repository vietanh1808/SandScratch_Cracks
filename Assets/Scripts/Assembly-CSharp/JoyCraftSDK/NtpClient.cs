using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public class NtpClient : JBase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetNetworkUtcAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DateTime?> _003C_003Et__builder;

			public int timeoutMs;

			public string host;

			public NtpClient _003C_003E4__this;

			private UdpClient _003Cudp_003E5__2;

			private TimeSpan _003Ctimeout_003E5__3;

			private UniTask<int>.Awaiter _003C_003Eu__1;

			private UniTask<UdpReceiveResult>.Awaiter _003C_003Eu__2;

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

		private const int NtpPort = 123;

		private const byte NtpRequestHeader = 27;

		private const int NtpPacketSize = 48;

		private const int TransmitTimestampOffset = 40;

		private const ulong TwoPow32 = 4294967296uL;

		private static readonly DateTime NtpEpoch;

		[AsyncStateMachine(typeof(_003CGetNetworkUtcAsync_003Ed__6))]
		public UniTask<DateTime?> GetNetworkUtcAsync(string host, int timeoutMs)
		{
			return default;
		}
	}
}
