namespace JTD.Logic
{
	internal enum RevenueOp
	{
		Enqueue = 0,
		PersistFirst = 1,
		FireSingle = 2,
		RemoveFromQueueOnAck = 3,
		PersistOnAck = 4
	}
}
