using System;

namespace JoyCraftSDK.Utilities
{
	public static class AssemblyUtils
	{
		[field: NonSerialized]
		public static bool IsReloading { get; private set; }

		static AssemblyUtils()
		{
		}

		private static void OnBeforeAssemblyReload()
		{
		}

		private static void OnAfterAssemblyReload()
		{
		}
	}
}
