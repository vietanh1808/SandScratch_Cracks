using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JTD.Logic;
using UnityEngine.Networking;

namespace JTD
{
	internal sealed class JTDClient
	{
		internal struct SendResult
		{
			public HttpResult Result;

			public string RetryAfter;

			public long StatusCode;

			public string Body;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SendResult> _003C_003Et__builder;

			public string url;

			public string json;

			public JTDClient _003C_003E4__this;

			public int timeoutSec;

			public CancellationToken ct;

			private UnityWebRequest _003Cuwr_003E5__2;

			private UniTask<UnityWebRequest>.Awaiter _003C_003Eu__1;

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

		private const string HeaderApiKey = "x-api-key";

		private const string PathBatch = "/v1/events";

		private const string PathSingle = "/v1/events/single";

		private readonly string _endpoint;

		private readonly string _apiKey;

		private const int SingleTimeoutSec = 5;

		internal JTDClient(string endpoint, string apiKey)
		{
		}

		internal UniTask<SendResult> SendBatchAsync(IReadOnlyList<EventContext> batch, CancellationToken ct)
		{
			return default;
		}

		internal UniTask<SendResult> SendSingleAsync(EventContext ev, CancellationToken ct)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CSendAsync_003Ed__10))]
		private UniTask<SendResult> SendAsync(string url, string json, CancellationToken ct, int timeoutSec = 0)
		{
			return default;
		}
	}
}
