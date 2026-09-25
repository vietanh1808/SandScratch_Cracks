using System;
using TouchScript.Pointers;

namespace TouchScript.Layers
{
	public class TouchLayerEventArgs : EventArgs
	{
		public Pointer Pointer { get; private set; }

		public TouchLayerEventArgs(Pointer pointer)
		{
		}
	}
}
