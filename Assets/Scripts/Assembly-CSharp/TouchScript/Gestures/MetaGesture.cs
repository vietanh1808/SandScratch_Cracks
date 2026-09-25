using System;
using System.Collections.Generic;
using TouchScript.Pointers;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures
{
	[AddComponentMenu("TouchScript/Gestures/Meta Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_MetaGesture.htm")]
	public sealed class MetaGesture : Gesture
	{
		public const string POINTER_PRESSED_MESSAGE = "OnPointerPressed";

		public const string POINTER_MOVED_MESSAGE = "OnPointerMoved";

		public const string POINTER_RELEASED_MESSAGE = "OnPointerReleased";

		public const string POINTER_CANCELLED_MESSAGE = "OnPointerCancelled";

		private EventHandler<MetaGestureEventArgs> pointerPressedInvoker;

		private EventHandler<MetaGestureEventArgs> pointerUpdatedInvoker;

		private EventHandler<MetaGestureEventArgs> pointerReleasedInvoker;

		private EventHandler<MetaGestureEventArgs> pointerCancelledInvoker;

		private CustomSampler gestureSampler;

		public event EventHandler<MetaGestureEventArgs> PointerPressed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<MetaGestureEventArgs> PointerUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<MetaGestureEventArgs> PointerReleased
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<MetaGestureEventArgs> PointerCancelled
		{
			add
			{
			}
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		[ContextMenu("Basic Editor")]
		private void switchToBasicEditor()
		{
		}

		protected override void pointersPressed(IList<Pointer> pointers)
		{
		}

		protected override void pointersUpdated(IList<Pointer> pointers)
		{
		}

		protected override void pointersReleased(IList<Pointer> pointers)
		{
		}

		protected override void pointersCancelled(IList<Pointer> pointers)
		{
		}
	}
}
