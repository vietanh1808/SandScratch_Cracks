using System.Diagnostics;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public class JDebug : ALogger
	{
		private const string DebugCondition = "UNITY_EDITOR";

		private const int DefaultSize = 22;

		private static string Prefix => null;

		public override void Log(object o)
		{
		}

		public override void Log(object o, JColor color)
		{
		}

		public override void Log(object o, Object context)
		{
		}

		public override void Log(object o, JColor color, Object context)
		{
		}

		public override void LogWarning(object o)
		{
		}

		public override void LogWarning(object o, Object context)
		{
		}

		public override void LogError(object o)
		{
		}

		public override void LogError(object o, Object context)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLog(object o)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLog(object o, JColor color)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLog(object o, Object context)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLog(object o, JColor color, Object context)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLogWarning(object o)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLogWarning(object o, Object context)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLogError(object o)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void StaticLogError(object o, Object context)
		{
		}

		public override void ProductionLog(object o)
		{
		}

		public override void ProductionLog(object o, JColor color)
		{
		}

		public override void ProductionLog(object o, Object context)
		{
		}

		public override void ProductionLog(object o, JColor color, Object context)
		{
		}

		public override void ProductionLogWarning(object o)
		{
		}

		public override void ProductionLogWarning(object o, Object context)
		{
		}

		public override void ProductionLogError(object o)
		{
		}

		public override void ProductionLogError(object o, Object context)
		{
		}

		public static void StaticProductionLog(object o)
		{
		}

		public static void StaticProductionLog(object o, JColor color)
		{
		}

		public static void StaticProductionLog(object o, Object context)
		{
		}

		public static void StaticProductionLogWarning(object o)
		{
		}

		public static void StaticProductionLogWarning(object o, Object context)
		{
		}

		public static void StaticProductionLogError(object o)
		{
		}

		public static void StaticProductionLogError(object o, Object context)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void ConfigureStackTrace()
		{
		}

		private static string GetPrintString(object o)
		{
			return null;
		}

		private static string GetPrintString(object o, JColor color)
		{
			return null;
		}
	}
}
