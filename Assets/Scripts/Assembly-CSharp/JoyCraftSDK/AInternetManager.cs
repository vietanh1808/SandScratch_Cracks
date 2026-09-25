using System;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class AInternetManager : JMonoBehaviour
	{
		public Relay OnCheckStarted;

		public Relay OnCheckFinished;

		public Relay OnConnectionStatusChanged;

		public Relay OnCheckTimeout;

		public abstract NetworkReachability InternetReachability { get; }

		public abstract InternetStatus InternetStatus { get; }

		public bool IsInternetAvailable()
		{
			return false;
		}

		public abstract void Init(Action onComplete = null);
	}
}
