using System.Diagnostics;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public static class JAssert
	{
		private const string Cond = "UNITY_ASSERTIONS";

		[Conditional("UNITY_ASSERTIONS")]
		public static void NotNull(object value, Object context = null, string hint = null)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition, Object context = null, string hint = null)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNullOrEmpty(string value, Object context = null, string hint = null)
		{
		}

		private static string BuildMsg(string what, Object context, string hint)
		{
			return null;
		}
	}
}
