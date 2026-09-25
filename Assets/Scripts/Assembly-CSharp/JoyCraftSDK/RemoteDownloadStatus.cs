namespace JoyCraftSDK
{
	public readonly struct RemoteDownloadStatus
	{
		public readonly long DownloadedBytes;

		public readonly long TotalBytes;

		public RemoteDownloadStatus(long downloadedBytes, long totalBytes)
		{
			DownloadedBytes = 0L;
			TotalBytes = 0L;
		}
	}
}
