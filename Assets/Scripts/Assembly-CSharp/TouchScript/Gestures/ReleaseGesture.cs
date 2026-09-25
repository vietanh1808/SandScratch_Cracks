using System;
using System.Collections.Generic;
using TouchScript.Pointers;
using TouchScript.Utils.Attributes;
using UnityEngine;
using UnityEngine.Profiling;

namespace TouchScript.Gestures
{
	[AddComponentMenu("TouchScript/Gestures/Release Gesture")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Gestures_ReleaseGesture.htm")]
	public class ReleaseGesture : Gesture
	{
		public const string RELEASE_MESSAGE = "OnRelease";

		private EventHandler<EventArgs> releasedInvoker;

		public GestureEvent OnRelease;

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

		public event EventHandler<EventArgs> Released
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

		protected override void pointersReleased(IList<Pointer> pointers)
		{
		}

		protected override void onRecognized()
		{
		}
	}
}
