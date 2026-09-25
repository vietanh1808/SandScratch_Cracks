using System;
using System.Collections.Generic;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures
{
	[AddComponentMenu("TouchScript/Gestures/Press Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_PressGesture.htm")]
	public class PressGesture : Gesture
	{
		public const string PRESS_MESSAGE = "OnPress";

		private EventHandler<EventArgs> pressedInvoker;

		public GestureEvent OnPress;

		[SerializeField]
		[ToggleLeft]
		private bool ignoreChildren;

		private CustomSampler gestureSampler;

		public bool IgnoreChildren
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event EventHandler<EventArgs> Pressed
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

		public override bool ShouldReceivePointer(Pointer pointer)
		{
			return false;
		}

		public override bool CanPreventGesture(Gesture gesture)
		{
			return false;
		}

		public override bool CanBePreventedByGesture(Gesture gesture)
		{
			return false;
		}

		protected override void pointersPressed(IList<Pointer> pointers)
		{
		}

		protected override void onRecognized()
		{
		}
	}
}
