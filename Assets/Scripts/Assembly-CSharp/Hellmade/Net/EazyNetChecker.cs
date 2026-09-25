using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Hellmade.Net
{
	[HelpURL("http://www.hellmadegames.com/Projects/eazy-netchecker/docs/manual/Manual.pdf")]
	[DisallowMultipleComponent]
	public class EazyNetChecker : MonoBehaviour
	{
		public delegate void Event();

		[CompilerGenerated]
		private sealed class _003CCheckConnectionCoroutine_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CCheckConnectionCoroutine_003Ed__101(int _003C_003E1__state)
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

		[CompilerGenerated]
		private static Event m_OnCheckStarted;

		[CompilerGenerated]
		private static Event m_OnCheckFinished;

		[CompilerGenerated]
		private static Event m_OnConnectionStatusChanged;

		[CompilerGenerated]
		private static Event m_OnCheckTimeout;

		private static EazyNetChecker instance;

		[SerializeField]
		private List<NetCheckMethod> methods;

		[SerializeField]
		private List<NetCheckMethod> customMethods;

		[SerializeField]
		private bool initialized;

		[SerializeField]
		private NetCheckMethod selectedMethod;

		[SerializeField]
		public bool platformDefaultSelected;

		private static Coroutine checkerCoroutine;

		private static bool keepChecking;

		private static float checkStartedTime;

		private static float nextCheckTime;

		private static bool stopOnSuccess;

		[SerializeField]
		private float timeout;

		[SerializeField]
		private bool continueCheckAfterTimeout;

		[SerializeField]
		private float checkIntervalNormal;

		[SerializeField]
		private float checkIntervalOnNoConnection;

		[SerializeField]
		private bool showDebug;

		public static float CheckInterval => 0f;

		public static float CheckIntervalNormal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float CheckIntervalOnNoConnection
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float Timeout
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static bool ContinueCheckAfterTimeout
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowDebug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool PlatformDefaultSelected => false;

		public static NetStatus Status { get; private set; }

		public static ErrorInfo ErrorInfo { get; private set; }

		public static NetworkReachability ReachabilityType => NetworkReachability.NotReachable;

		public static bool IsChecking { get; private set; }

		public static float NextCheckRemaingSeconds => 0f;

		public static float Runtime { get; private set; }

		public static float Uptime { get; private set; }

		public static float Downtime { get; private set; }

		public static EazyNetChecker Instance => null;

		public static event Event OnCheckStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Event OnCheckFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Event OnConnectionStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Event OnCheckTimeout
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual void Awake()
		{
		}

		private void Update()
		{
		}

		public static void Init()
		{
		}

		public static void SetStandardCheckMethods()
		{
		}

		public static List<NetCheckMethod> GetStandardMethods()
		{
			return null;
		}

		public static NetCheckMethod GetGoogle204Method()
		{
			return null;
		}

		public static NetCheckMethod GetMicrosoftConnectTestMethod()
		{
			return null;
		}

		public static NetCheckMethod GetAppleHotspotMethod()
		{
			return null;
		}

		public static List<NetCheckMethod> GetCustomMethods()
		{
			return null;
		}

		public static NetCheckMethod GetCustomMethod(string methodID)
		{
			return null;
		}

		public static NetCheckMethod GetDefaultMethod()
		{
			return null;
		}

		public static NetCheckMethod GetSelectedMethod()
		{
			return null;
		}

		public static void AddCustomMethod(NetCheckMethod method)
		{
		}

		public static void AddCustomMethod(NetCheckMethod method, bool use)
		{
		}

		public static void UseMethod(NetCheckMethod method)
		{
		}

		public static void UseDefaultMethod()
		{
		}

		public static void UseGoogle204Method()
		{
		}

		public static void UseMicrosoftConnectTestMethod()
		{
		}

		public static void UseAppleHotspotMethod()
		{
		}

		public static void StartConnectionCheck()
		{
		}

		public static void StartConnectionCheck(bool stopOnSuccess, bool interruptActiveChecks)
		{
		}

		public static void StopConnectionCheck()
		{
		}

		public static void CheckConnection()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckConnectionCoroutine_003Ed__101))]
		private static IEnumerator CheckConnectionCoroutine()
		{
			return null;
		}
	}
}
