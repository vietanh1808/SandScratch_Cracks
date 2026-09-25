using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JTD.Logic;
using JoyCraftSDK.Analytics;

namespace JTD
{
	public sealed class JTDAnalyticsPlatform : AAnalyticsPlatform
	{
		[CompilerGenerated]
		private static Action<JTDIapVerifyResult> m_OnIapVerifyResult;

		private readonly JTDSettings _settings;

		private readonly IJTDHost _host;

		private JTDSession _session;

		private JTDEventQueue _queue;

		private readonly JTDRollupBuffer _rollupBuffer;

		private bool _overflowWarned;

		private IReadOnlyDictionary<string, string> _eventContext;

		public override string PlatformName => null;

		public string InstallDate => null;

		public static event Action<JTDIapVerifyResult> OnIapVerifyResult
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

		internal static void RaiseIapVerifyResult(JTDIapVerifyResult result)
		{
		}

		public JTDAnalyticsPlatform(JTDSettings settings, IJTDHost host)
		{
		}

		public override void Initialize(Action onComplete = null)
		{
		}

		public void FlushNow()
		{
		}

		protected override void OnLogEvent(JAnalyticEvent analyticsEvent)
		{
		}

		private void BufferRollup(JTDRollupEvent rollup, long tsMs)
		{
		}

		public void FlushAllCounters()
		{
		}

		private void EmitFrozen(JTDRollupBuffer.Bucket bucket)
		{
		}

		private EventContext BuildContext(string eventId, long ts, string eventName, Dictionary<string, object> props)
		{
			return null;
		}

		public override void SetUserId(string userId)
		{
		}

		public void SetEventContext(IDictionary<string, string> ctx)
		{
		}
	}
}
