using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public class DownloadFailRetryTracker : JBase
	{
		private readonly HashSet<int> _failedLevelsThisSession;

		public bool RegisterFail(int level)
		{
			return false;
		}

		public void Clear()
		{
		}
	}
}
