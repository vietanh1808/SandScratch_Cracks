using System;
using TouchScript.Pointers;

namespace TouchScript.Gestures
{
	public class MetaGestureEventArgs : EventArgs
	{
		public Pointer Pointer { get; private set; }

		public MetaGestureEventArgs(Pointer pointer)
		{
		}
	}
}
