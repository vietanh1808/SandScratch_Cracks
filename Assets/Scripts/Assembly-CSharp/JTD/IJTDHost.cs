using System;
using System.Threading;

namespace JTD
{
	public interface IJTDHost
	{
		CancellationToken AppLifetimeToken { get; }

		event Action<bool> ApplicationPause;

		event Action ApplicationQuit;
	}
}
