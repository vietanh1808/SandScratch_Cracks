using System;
using Firebase;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK
{
	public abstract class ABackendManager : JBase
	{
		public FirebaseApp FirebaseApp;

		public bool IsFirebaseReady;

		public Relay<FirebaseApp> OnFirebaseReady;

		public abstract void Init(Action onComplete = null);

		public abstract void SetUserID();

		public abstract void CrashLog(string message);

		public abstract void CrashSetKey(string key, string value);
	}
}
