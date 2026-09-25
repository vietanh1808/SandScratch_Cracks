using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class APageButtonSetup : JMonoBehaviour
	{
		public abstract void Init();

		public abstract void OnSelect();

		public abstract void OnDeselect();

		public virtual void SetProgress(float progress)
		{
		}
	}
}
