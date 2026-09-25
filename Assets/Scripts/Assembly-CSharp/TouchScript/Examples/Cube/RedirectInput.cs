using System.Collections.Generic;
using TouchScript.Gestures;
using TouchScript.InputSources;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Examples.Cube
{
	public class RedirectInput : InputSource
	{
		public int Width;

		public int Height;

		private MetaGesture gesture;

		private Dictionary<int, Pointer> map;

		public override bool CancelPointer(Pointer pointer, bool shouldReturn)
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private Vector2 processCoords(Vector2 value)
		{
			return default;
		}

		private void pointerPressedHandler(object sender, MetaGestureEventArgs metaGestureEventArgs)
		{
		}

		private void pointerUpdatedHandler(object sender, MetaGestureEventArgs metaGestureEventArgs)
		{
		}

		private void pointerReleasedHandler(object sender, MetaGestureEventArgs metaGestureEventArgs)
		{
		}

		private void pointerCancelledhandler(object sender, MetaGestureEventArgs metaGestureEventArgs)
		{
		}
	}
}
