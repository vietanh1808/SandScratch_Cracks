namespace JoyCraftSDK.LiveEvent
{
	public readonly struct LiveEventMilestoneTier
	{
		public readonly int Tier;

		public readonly LiveEventMilestoneEntry FreeEntry;

		public readonly LiveEventMilestoneEntry PremiumEntry;

		public LiveEventMilestoneTier(int tier, LiveEventMilestoneEntry freeEntry, LiveEventMilestoneEntry premiumEntry)
		{
			Tier = 0;
			FreeEntry = null;
			PremiumEntry = null;
		}
	}
}
