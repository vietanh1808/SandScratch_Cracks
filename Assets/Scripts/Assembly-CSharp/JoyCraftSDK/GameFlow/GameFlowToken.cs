using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameFlow
{
	public static class GameFlowToken
	{
		public const string LevelLoaded = "LevelLoaded";

		public const string LoseCondition = "LoseCondition";

		public static string Panel(UIPanelID panelID)
		{
			return null;
		}

		public static string Scene(SceneIndex scene)
		{
			return null;
		}

		public static string LevelFinished(LevelFinishReason reason)
		{
			return null;
		}

		public static string Checkpoint(string id)
		{
			return null;
		}

		public static string Action(string verb)
		{
			return null;
		}
	}
}
