using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AScenesManager : JMonoBehaviour
	{
		public abstract bool IsAdditiveSceneLoaded(string sceneName);

		public abstract void RegisterAdditiveScene(string sceneName);

		public abstract void UnregisterAdditiveScene(string sceneName);

		public abstract string GetSceneName(SceneIndex sceneIndex);
	}
}
