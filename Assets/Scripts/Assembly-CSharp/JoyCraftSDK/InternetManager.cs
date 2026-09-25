using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public class InternetManager : AInternetManager
	{
		public static readonly bool _logging;

		private Action _onComplete;

		public override NetworkReachability InternetReachability => NetworkReachability.NotReachable;

		public override InternetStatus InternetStatus => InternetStatus.PendingCheck;

		public override void Init(Action onComplete = null)
		{
		}

		public override void Awake()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void InvokeOnCheckStarted()
		{
		}

		private void InvokeOnCheckFinished()
		{
		}

		private void InvokeOnCheckTimeout()
		{
		}

		private void InvokeOnConnectionStatusChanged()
		{
		}
	}
}
