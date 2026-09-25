namespace JTD.Logic
{
	internal readonly struct JTDIapVerdict
	{
		internal readonly string Status;

		internal readonly string Subreason;

		internal readonly string PurchaseType;

		internal JTDIapVerdict(string status, string subreason, string purchaseType)
		{
			Status = null;
			Subreason = null;
			PurchaseType = null;
		}
	}
}
