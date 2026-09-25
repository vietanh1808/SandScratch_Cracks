namespace JoyCraftSDK.Game
{
	public class OnRemoteDownloadProgress : IEvent
	{
		public int level;

		public long downloadedBytes;

		public long totalBytes;
	}
}
