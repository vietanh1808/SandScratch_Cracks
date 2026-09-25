using System;
using GenericEventBus;

namespace JoyCraftSDK
{
	public class JEventBus<TBaseEvent> : GenericEventBus<TBaseEvent>
	{
		private const int MaxReportsPerSession = 10;

		private static int _reportCount;

		public Action<string> CrashLogger;

		public override bool Raise<TEvent>(in TEvent @event)
		{
			return false;
		}

		public override bool RaiseImmediately<TEvent>(ref TEvent @event)
		{
			return false;
		}

		private void ReportWrongThread(string eventName)
		{
		}
	}
}
