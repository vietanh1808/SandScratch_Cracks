using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ALoadSceneManager : JBase
	{
		public abstract void LoadSingleSceneAsNew(SceneIndex toExit, SceneIndex toEnter, Action actionOnLoadFinish = null);

		public abstract void LoadAdditiveScene(SceneIndex sceneIndex, Action onComplete = null);

		public abstract void UnloadAdditiveScene(SceneIndex sceneIndex, Action onComplete = null);

		public abstract UniTaskVoid StartInitProgress();

		public abstract void OnInitComplete();
	}
}
