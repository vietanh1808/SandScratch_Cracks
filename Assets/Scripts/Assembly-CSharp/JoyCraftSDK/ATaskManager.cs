using System;
using System.Threading;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class ATaskManager : MonoBehaviour
	{
		public abstract void DoAfterSeconds(float seconds, Action action, CancellationToken cancellationToken = default(CancellationToken));

		public abstract void DoAfterRealSeconds(float seconds, Action action, CancellationToken cancellationToken = default(CancellationToken));

		public abstract void DoAfterSecondsUnsafe(float seconds, Action action, Action<Exception> onException);

		public abstract void DoAfterRealSecondsUnsafe(float seconds, Action action, Action<Exception> onException);

		public abstract void DoNextFrame(Action action, CancellationToken cancellationToken = default(CancellationToken));

		public abstract void DoAfterFrames(uint count, Action action, CancellationToken cancellationToken = default(CancellationToken));

		public abstract void DoEndOffFrame(Action action, MonoBehaviour caller = null);

		public abstract void DoWhen(Func<bool> predicate, Action action);
	}
}
