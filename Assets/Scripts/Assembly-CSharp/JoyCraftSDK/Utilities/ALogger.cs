using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public abstract class ALogger : JMonoBehaviour, ILogger
	{
		public abstract void Log(object o);

		public abstract void Log(object o, JColor color);

		public abstract void Log(object o, Object context);

		public abstract void Log(object o, JColor color, Object context);

		public abstract void LogWarning(object o);

		public abstract void LogWarning(object o, Object context);

		public abstract void LogError(object o);

		public abstract void LogError(object o, Object context);

		public abstract void ProductionLog(object o);

		public abstract void ProductionLog(object o, JColor color);

		public abstract void ProductionLog(object o, Object context);

		public abstract void ProductionLog(object o, JColor color, Object context);

		public abstract void ProductionLogWarning(object o);

		public abstract void ProductionLogWarning(object o, Object context);

		public abstract void ProductionLogError(object o);

		public abstract void ProductionLogError(object o, Object context);
	}
}
