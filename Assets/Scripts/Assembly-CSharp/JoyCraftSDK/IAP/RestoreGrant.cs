namespace JoyCraftSDK.IAP
{
	public readonly struct RestoreGrant
	{
		public readonly RewardKind Kind;

		public readonly int Amount;

		public readonly RestoreGrantReason Reason;

		public readonly string ProductID;

		public RestoreGrant(RewardKind kind, int amount, RestoreGrantReason reason, string productID)
		{
			Kind = RewardKind.None;
			Amount = 0;
			Reason = RestoreGrantReason.Entitlement;
			ProductID = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
