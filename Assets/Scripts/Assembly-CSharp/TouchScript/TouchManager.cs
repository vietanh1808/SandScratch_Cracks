using System;
using System.Collections.Generic;
using TouchScript.Core;
using TouchScript.Devices.Display;
using TouchScript.Layers;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace TouchScript
{
	[AddComponentMenu("TouchScript/Touch Manager")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_TouchManager.htm")]
	public sealed class TouchManager : DebuggableMonoBehaviour
	{
		[Serializable]
		public class PointerEvent : UnityEvent<IList<Pointer>>
		{
		}

		[Serializable]
		public class FrameEvent : UnityEvent
		{
		}

		[Flags]
		public enum MessageType
		{
			FrameStarted = 1,
			FrameFinished = 2,
			PointersAdded = 4,
			PointersUpdated = 8,
			PointersPressed = 0x10,
			PointersReleased = 0x20,
			PointersRemoved = 0x40,
			PointersCancelled = 0x80
		}

		public enum MessageName
		{
			OnFrameStart = 1,
			OnFrameFinish = 2,
			OnPointersAdd = 4,
			OnPointersUpdate = 8,
			OnPointersPress = 0x10,
			OnPointersRelease = 0x20,
			OnPointersRemove = 0x40,
			OnPointersCancel = 0x80
		}

		public const float CM_TO_INCH = 50f / 127f;

		public const float INCH_TO_CM = 2.54f;

		public static readonly Vector2 INVALID_POSITION;

		public static readonly Version VERSION;

		public static readonly string VERSION_SUFFIX;

		public FrameEvent OnFrameStart;

		[SerializeField]
		public FrameEvent OnFrameFinish;

		[SerializeField]
		public PointerEvent OnPointersAdd;

		[SerializeField]
		public PointerEvent OnPointersUpdate;

		[SerializeField]
		public PointerEvent OnPointersPress;

		[SerializeField]
		public PointerEvent OnPointersRelease;

		[SerializeField]
		public PointerEvent OnPointersRemove;

		[SerializeField]
		public PointerEvent OnPointersCancel;

		[SerializeField]
		[HideInInspector]
		private bool basicEditor;

		[SerializeField]
		private UnityEngine.Object displayDevice;

		[SerializeField]
		[ToggleLeft]
		private bool shouldCreateCameraLayer;

		[SerializeField]
		[ToggleLeft]
		private bool shouldCreateStandardInput;

		[SerializeField]
		[ToggleLeft]
		private bool useSendMessage;

		[SerializeField]
		private MessageType sendMessageEvents;

		[SerializeField]
		private GameObject sendMessageTarget;

		[SerializeField]
		private bool useUnityEvents;

		[SerializeField]
		private List<TouchLayer> layers;

		public static ITouchManager Instance => null;

		public IDisplayDevice DisplayDevice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ShouldCreateCameraLayer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShouldCreateStandardInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseSendMessage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MessageType SendMessageEvents
		{
			get
			{
				return (MessageType)0;
			}
			set
			{
			}
		}

		public GameObject SendMessageTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseUnityEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsInvalidPosition(Vector2 position)
		{
			return false;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[ContextMenu("Basic Editor")]
		private void switchToBasicEditor()
		{
		}

		private void updateSendMessageSubscription()
		{
		}

		private void removeSendMessageSubscriptions()
		{
		}

		private void pointersAddedSendMessageHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersUpdatedSendMessageHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersPressedSendMessageHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersReleasedSendMessageHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersRemovedSendMessageHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersCancelledSendMessageHandler(object sender, PointerEventArgs e)
		{
		}

		private void frameStartedSendMessageHandler(object sender, EventArgs e)
		{
		}

		private void frameFinishedSendMessageHandler(object sender, EventArgs e)
		{
		}

		private void updateUnityEventsSubscription()
		{
		}

		private void removeUnityEventsSubscriptions()
		{
		}

		private void pointersAddedUnityEventsHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersUpdatedUnityEventsHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersPressedUnityEventsHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersReleasedUnityEventsHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersRemovedUnityEventsHandler(object sender, PointerEventArgs e)
		{
		}

		private void pointersCancelledUnityEventsHandler(object sender, PointerEventArgs e)
		{
		}

		private void frameStartedUnityEventsHandler(object sender, EventArgs e)
		{
		}

		private void frameFinishedUnityEventsHandler(object sender, EventArgs e)
		{
		}
	}
}
