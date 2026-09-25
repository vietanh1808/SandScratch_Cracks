using System;
using System.Collections.Generic;
using TouchScript.Pointers;

namespace TouchScript
{
	public class PointerEventArgs : EventArgs
	{
		private static PointerEventArgs instance;

		public IList<Pointer> Pointers { get; private set; }

		private PointerEventArgs()
		{
		}

		public static PointerEventArgs GetCachedEventArgs(IList<Pointer> pointers)
		{
			return null;
		}
	}
}
