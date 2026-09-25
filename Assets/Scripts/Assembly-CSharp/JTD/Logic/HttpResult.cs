namespace JTD.Logic
{
	internal enum HttpResult
	{
		None = 0,
		Ok = 1,
		DropClient = 2,
		RetryServer = 3,
		Backpressure = 4
	}
}
