using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ASaveDatabaseService : JMonoBehaviour
	{
		public abstract ALocalDatabaseService LocalDataReloader { get; }

		public abstract UniTask SaveGameData(SavedGameData data);

		public abstract UniTask<SavedGameData> LoadGameDataAsync();

		public abstract UniTask Init(Action onComplete = null);
	}
}
