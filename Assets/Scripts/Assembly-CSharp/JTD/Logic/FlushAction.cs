namespace JTD.Logic
{
	internal enum FlushAction
	{
		Swap = 0,
		Ack = 1,
		Drop = 2,
		Backoff429 = 3,
		BackoffRetry = 4,
		GiveUpMerge = 5,
		Noop = 6
	}
}
