using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ALocalDatabaseService : JMonoBehaviour
	{
		public abstract UniTask<SavedGameData> SaveAndReloadData(SavedGameData newData);
	}
}
