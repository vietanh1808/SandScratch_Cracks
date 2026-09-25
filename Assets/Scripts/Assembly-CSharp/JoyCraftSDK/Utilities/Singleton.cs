namespace JoyCraftSDK.Utilities
{
	public class Singleton<T> : JMonoBehaviour where T : JMonoBehaviour
	{
		private static T _instance;

		private static readonly object _lock;

		protected static bool applicationIsQuitting;

		public static T Instance => null;

		public override void Awake()
		{
		}

		public new virtual void OnApplicationQuit()
		{
		}
	}
}
