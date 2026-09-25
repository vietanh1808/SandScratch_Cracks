namespace JoyCraftSDK
{
	public readonly struct RemoteContentSizeResult
	{
		public RemoteContentSizeStatus Status { get; }

		public long Bytes { get; }

		public string ErrorMessage { get; }

		public bool IsOk => false;

		public RemoteContentSizeResult(RemoteContentSizeStatus status, long bytes, string errorMessage = "")
		{
			Status = RemoteContentSizeStatus.None;
			Bytes = 0L;
			ErrorMessage = null;
		}

		public static RemoteContentSizeResult Ok(long bytes)
		{
			return default;
		}

		public static RemoteContentSizeResult KeyMissing(string errorMessage)
		{
			return default;
		}

		public static RemoteContentSizeResult Failed(string errorMessage)
		{
			return default;
		}
	}
}
