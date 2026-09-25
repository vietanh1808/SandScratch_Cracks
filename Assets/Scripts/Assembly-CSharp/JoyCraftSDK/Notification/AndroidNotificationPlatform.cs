using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.Utilities;
using Unity.Notifications.Android;
using UnityEngine;

namespace JoyCraftSDK.Notification
{
	public class AndroidNotificationPlatform : JBase, INotificationPlatform
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestPermissionAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Action<NotificationPermissionStatus> onComplete;

			private PermissionRequest _003Crequest_003E5__2;

			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public string PlatformName => null;

		public bool IsAvailable => false;

		public NotificationPermissionStatus PermissionStatus => NotificationPermissionStatus.Unknown;

		public void Initialize(NotificationChannelData channel)
		{
		}

		public void RequestPermission(Action<NotificationPermissionStatus> onComplete)
		{
		}

		public void OpenSystemNotificationSettings()
		{
		}

		public void Schedule(NotificationRequest request)
		{
		}

		public bool TryGetLastOpenedId(out int id)
		{
			id = default;
			return false;
		}

		public void Cancel(int id)
		{
		}

		public void CancelAllScheduled()
		{
		}

		public void ClearDelivered()
		{
		}

		private bool TryStartActivity(AndroidJavaObject currentActivity, string action, string extraKey, string extraValue)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CRequestPermissionAsync_003Ed__15))]
		private UniTaskVoid RequestPermissionAsync(Action<NotificationPermissionStatus> onComplete)
		{
			return default;
		}

		private static NotificationPermissionStatus Map(PermissionStatus status)
		{
			return NotificationPermissionStatus.Unknown;
		}
	}
}
