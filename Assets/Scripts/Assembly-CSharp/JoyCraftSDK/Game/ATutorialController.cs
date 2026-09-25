using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATutorialController : JMonoBehaviour
	{
		public abstract void Play();

		public abstract void Play(TutorialFlow flow);

		public abstract void Play(TutorialType type);

		public abstract void SetCompleteAll();

		public abstract TutorialFlow GetFlowForLevel(int level);
	}
}
