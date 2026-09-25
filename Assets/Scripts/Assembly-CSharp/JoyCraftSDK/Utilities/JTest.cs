namespace JoyCraftSDK.Utilities
{
	public abstract class JTest : JMonoBehaviour
	{
		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected abstract void OnTest(ref AEventManager.OnStartTestScene eventData);
	}
}
