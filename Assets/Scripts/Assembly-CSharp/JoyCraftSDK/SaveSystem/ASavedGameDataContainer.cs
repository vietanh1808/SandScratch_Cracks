using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ASavedGameDataContainer : JScriptableObject
	{
		public abstract SavedGameData GetData();
	}
}
