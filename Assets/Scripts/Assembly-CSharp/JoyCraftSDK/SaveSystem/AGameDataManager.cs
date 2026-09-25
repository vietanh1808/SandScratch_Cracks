using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class AGameDataManager : JMonoBehaviour
	{
		public SavedGameData savedGameData;

		public abstract UniTask Init(Action onComplete = null);

		public abstract void SaveGameDataAndForget();

		public abstract UniTask SaveAndReloadDataAsync(Action onComplete = null);

		protected string GenerateUserId()
		{
			return null;
		}
	}
}
