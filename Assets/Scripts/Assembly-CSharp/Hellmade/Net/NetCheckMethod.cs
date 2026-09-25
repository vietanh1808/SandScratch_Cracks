using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace Hellmade.Net
{
	[Serializable]
	public class NetCheckMethod
	{
		[CompilerGenerated]
		private sealed class _003CCheck_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetCheckMethod _003C_003E4__this;

			private float _003CstartMillisecondsTime_003E5__2;

			private UnityWebRequest _003Cwww_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheck_003Ed__11(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public string id;

		public string link;

		public NetCheckResponseType responseType;

		public HttpStatusCode expectedHttpStatusCode;

		public string expectedContent;

		private NetStatus status;

		private ErrorInfo errorInfo;

		private float responseTime;

		public NetCheckMethod(string id, string link, HttpStatusCode expectedHttpStatusCode)
		{
		}

		public NetCheckMethod(string id, string link, string expectedContent, bool contentContain = false)
		{
		}

		public NetCheckMethod(string id, string link, NetCheckResponseType responseType, HttpStatusCode expectedHttpStatusCode, string expectedContent)
		{
		}

		[IteratorStateMachine(typeof(_003CCheck_003Ed__11))]
		public IEnumerator Check()
		{
			return null;
		}

		public NetStatus GetCheckStatus()
		{
			return NetStatus.PendingCheck;
		}

		public ErrorInfo GetErrorInfo()
		{
			return null;
		}

		public float GetResponseTime()
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
