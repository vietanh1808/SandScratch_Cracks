using System;
using System.Runtime.CompilerServices;
using System.Threading;
using JTD;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Analytics
{
	[DefaultExecutionOrder(100)]
	public sealed class JTDBootstrap : JMonoBehaviour, IJTDHost
	{
		private static JTDBootstrap _instance;

		private bool _wired;

		private JTDAnalyticsPlatform _platform;

		[CompilerGenerated]
		private Action<bool> m_ApplicationPause;

		[CompilerGenerated]
		private Action m_ApplicationQuit;

		public static JTDAnalyticsPlatform Platform => null;

		public CancellationToken AppLifetimeToken => default;

		public event Action<bool> ApplicationPause
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

		public event Action ApplicationQuit
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

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void WireJTD()
		{
		}

		protected override void OnApplicationPause(bool pauseStatus)
		{
		}

		protected override void OnApplicationQuit()
		{
		}
	}
}
