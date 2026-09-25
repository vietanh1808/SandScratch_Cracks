using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	public readonly struct LevelOutcome
	{
		public readonly int Context;

		public readonly int LevelAbandoned;

		public readonly string Result;

		public readonly string LoseCause;

		private LevelOutcome(int context, int levelAbandoned, string result, string loseCause)
		{
			Context = 0;
			LevelAbandoned = 0;
			Result = null;
			LoseCause = null;
		}

		public static LevelOutcome From(LevelFinishReason reason, LevelFailReason failReason)
		{
			return default;
		}
	}
}
