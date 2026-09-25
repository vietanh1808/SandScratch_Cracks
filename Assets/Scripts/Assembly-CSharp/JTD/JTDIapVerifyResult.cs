namespace JTD
{
	public readonly struct JTDIapVerifyResult
	{
		public readonly string EventId;

		public readonly string TransactionId;

		public readonly string Status;

		public readonly string Subreason;

		public readonly string PurchaseType;

		public JTDIapVerifyResult(string eventId, string transactionId, string status, string subreason, string purchaseType)
		{
			EventId = null;
			TransactionId = null;
			Status = null;
			Subreason = null;
			PurchaseType = null;
		}
	}
}
