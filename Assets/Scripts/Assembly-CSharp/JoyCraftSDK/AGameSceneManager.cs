using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AGameSceneManager : JMonoBehaviour
	{
		public abstract SceneIndex ThisSceneIndex { get; }

		public abstract void SetupScene(ref AEventManager.OnSetupSceneStart eventData);

		public abstract void StartPlayNextFrame();
	}
}
