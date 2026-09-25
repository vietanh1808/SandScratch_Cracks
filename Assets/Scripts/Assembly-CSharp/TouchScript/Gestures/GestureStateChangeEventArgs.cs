using System;

namespace TouchScript.Gestures
{
	public class GestureStateChangeEventArgs : EventArgs
	{
		private static GestureStateChangeEventArgs instance;

		public Gesture.GestureState PreviousState { get; private set; }

		public Gesture.GestureState State { get; private set; }

		public static GestureStateChangeEventArgs GetCachedEventArgs(Gesture.GestureState state, Gesture.GestureState previousState)
		{
			return null;
		}
	}
}
