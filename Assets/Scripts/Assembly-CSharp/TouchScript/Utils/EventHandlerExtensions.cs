using System;

namespace TouchScript.Utils
{
	public static class EventHandlerExtensions
	{
		public static Exception InvokeHandleExceptions<T>(this EventHandler<T> handler, object sender, T args) where T : EventArgs
		{
			return null;
		}

		public static Exception InvokeHandleExceptions(this EventHandler handler, object sender, EventArgs args)
		{
			return null;
		}
	}
}
