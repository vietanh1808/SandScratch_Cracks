using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	public interface ILogger
	{
		void Log(object o);

		void Log(object o, JColor color);

		void Log(object o, Object context);

		void Log(object o, JColor color, Object context);

		void LogWarning(object o);

		void LogWarning(object o, Object context);

		void LogError(object o);

		void LogError(object o, Object context);

		void ProductionLog(object o);

		void ProductionLog(object o, JColor color);

		void ProductionLog(object o, Object context);

		void ProductionLog(object o, JColor color, Object context);

		void ProductionLogWarning(object o);

		void ProductionLogWarning(object o, Object context);

		void ProductionLogError(object o);

		void ProductionLogError(object o, Object context);
	}
}
